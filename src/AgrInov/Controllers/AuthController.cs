using AgrInov.Data;
using AgrInov.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(senha, usuario.Senha);

            if(senhaOk)
            {
                HttpContext.Session.SetString("UsuarioId", usuario.Id.ToString());
                HttpContext.Session.SetString("UsuarioNome", usuario.Nome);
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

                HttpContext.Session.SetString("UsuarioId", usuario.Id.ToString());
                HttpContext.Session.SetString("UsuarioNome", usuario.Nome);
                return RedirectToAction("Index", "Home");
            }

            return View(usuario);
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}