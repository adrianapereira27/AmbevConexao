namespace AmbevConexao.API.Mid
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"[{DateTime.Now}] [{nameof(CustomMiddleware)}]: Antes de executar a rota {context.Request.Path}"); 
            
            await _next(context);

            Console.WriteLine($"[{DateTime.Now}] [{nameof(CustomMiddleware)}]: Depois de executar a rota {context.Request.Path}");

        }

    }
}
