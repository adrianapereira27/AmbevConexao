using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace AmbevConexao.API.Filtros
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            var mensagem = "Um erro inesperado aconteceu";

            if (context.Exception is NotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                mensagem = "Recurso não encontrado";
            }

            context.Result = new ObjectResult(
                new
                {
                    StatusCode = (int)statusCode,
                    Mensagem = mensagem,
                    Detalhe = context.Exception.Message
                })
            {
                StatusCode = (int)statusCode
            };

            context.ExceptionHandled = true;

        }
    }
        
    public class NotFoundException : Exception
    {       
        public NotFoundException(string message) : base(message)
        {
        }               
    }
}
