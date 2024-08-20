namespace AmbevConexao.API.Mid
{
    public class ValidateMiddleware
    {
        private readonly RequestDelegate _next;

        public ValidateMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string chave = "ambev";

            if (!context.Request.Headers.ContainsKey(chave))
            {
                context.Response.StatusCode = 400;   // retorna um Bad Request se a chave não existir
                await context.Response.WriteAsync("Chave não encontrada.");
                return;
            }

            await _next(context);

        }
    }
}
