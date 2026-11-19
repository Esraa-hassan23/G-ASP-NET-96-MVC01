using System.Diagnostics;

namespace MVC01.MiddleWares
{
    public class TimeRequestMiddleWare
    {
       

        private readonly RequestDelegate _next;

       public TimeRequestMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var mywatch =  Stopwatch.StartNew();

            await _next(context);

            mywatch.Stop();

            Console.WriteLine($"{context.Request.Path} ---> {mywatch.ElapsedMilliseconds}msec");
        }
    }
}
