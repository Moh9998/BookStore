using BookStore.Models;

namespace BookStore.Logic_Business
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("Handling request: {Path}", context.Request.Path);

            // Copy the original response stream
            var originalBodyStream = context.Response.Body;

            // Create a new memory stream to write the response
            using (var responseBody = new MemoryStream())
            {
                // Replace the original stream with the memory stream
                context.Response.Body = responseBody;

                // Continue processing the request
                await _next(context);

                // Log the response
                _logger.LogInformation("Handled request: {Path}, Status: {StatusCode}", context.Request.Path, context.Response.StatusCode);

                // Restore the original response body
                responseBody.Seek(0, SeekOrigin.Begin);
                await responseBody.CopyToAsync(originalBodyStream);
            }
        }
    }


}
