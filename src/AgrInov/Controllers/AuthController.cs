using AgrInov.Data;
using AgrInov.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using BCrypt.Net;

namespace AgrInov.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == email);

            if (usuario == null)
            {
                ViewBag.Erro = "Email ou senha inválidos";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(senha, usuario.Senha);

            if (senhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email)
                };

                var usuarioIdentity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Erro = "Email ou senha inválidos";
            }

            return View();
        }

        // GET: Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        // POST: Cadastro
        [HttpPost]
        public async Task<IActionResult> Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var emailExiste = await _context.Usuarios
                    .AnyAsync(u => u.Email == usuario.Email);

                if (emailExiste)
                {
                    ViewBag.Erro = "Email já cadastrado";
                    return View(usuario);
                }

                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email)
                };

                var usuarioIdentity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);
                return RedirectToAction("Index", "Home");
            }

            return View(usuario);
        }

        // Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}