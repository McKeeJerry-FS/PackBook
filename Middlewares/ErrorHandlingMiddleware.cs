using System;

namespace PackBook.Middlewares;

public class ErrorHandlingMiddleware
{

  private readonly RequestDelegate _next;
  public ErrorHandlingMiddleware(RequestDelegate next)
  {
    _next = next;
  }

  public async Task InvokeAsync(HttpContext context)
  {
    try
    {
      await _next(context);
    }
    catch (Exception ex)
    {
      // Log the exception (you can replace this with your logging framework)
      Console.WriteLine($"An error occurred: {ex.Message}");

      // Return a generic error response
      context.Response.StatusCode = 500; // Internal Server Error
      await context.Response.WriteAsync("An unexpected error occurred. Please try again later.");

      // Log the exception details here
    }
  }
}
