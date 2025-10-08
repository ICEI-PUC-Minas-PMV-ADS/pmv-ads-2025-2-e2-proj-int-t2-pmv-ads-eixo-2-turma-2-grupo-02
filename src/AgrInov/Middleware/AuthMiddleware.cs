namespace AgrInov.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value?.ToLower();
            var isAuthPath = path?.Contains("/auth/") == true;
            var isLoggedIn = context.Session.GetString("UsuarioId") != null;

            // Se não está logado e não está tentando acessar páginas de auth, redireciona para login
            if (!isLoggedIn && !isAuthPath && path != "/")
            {
                context.Response.Redirect("/Auth/Login");
                return;
            }

            // Se está logado e tenta acessar login, redireciona para home
            if (isLoggedIn && path == "/auth/login")
            {
                context.Response.Redirect("/Home/Index");
                return;
            }

            await _next(context);
        }
    }
}