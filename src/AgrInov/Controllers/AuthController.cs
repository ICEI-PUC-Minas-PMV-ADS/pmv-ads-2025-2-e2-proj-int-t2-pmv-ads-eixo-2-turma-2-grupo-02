using AgrInov.Data;
using AgrInov.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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
        public async Task<IActionResult> Login()
        {
            var temUsuarios = await _context.Usuarios.AnyAsync();

            // Se não há usuários, redireciona para cadastro
            if (!temUsuarios)
            {
                return RedirectToAction("Cadastro");
            }

            ViewBag.TemUsuarios = temUsuarios;
            return View();
        }

        // POST: Login
        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var usuario = await _context.Usuarios
                .Include(u => u.Cargo)
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

                if (usuario.Cargo != null)
                {
                    claims.Add(new Claim(ClaimTypes.Role, usuario.Cargo.Nome));
                }

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
        public async Task<IActionResult> Cadastro()
        {
            // Se já há usuários, bloqueia acesso ao cadastro
            var temUsuarios = await _context.Usuarios.AnyAsync();
            if (temUsuarios)
            {
                return RedirectToAction("Login");
            }

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

                // Se é o primeiro usuário, cria cargo TI e atribui ao usuário
                var cargoTI = await _context.Cargos.FirstOrDefaultAsync(c => c.Nome == "TI");
                if (cargoTI == null)
                {
                    cargoTI = new Cargo { Nome = "TI", Descricao = "Tecnologia da Informação" };
                    _context.Cargos.Add(cargoTI);
                    await _context.SaveChangesAsync();
                }

                usuario.CargoId = cargoTI.Id;
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Email, usuario.Email),
                    new Claim(ClaimTypes.Role, "TI")
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