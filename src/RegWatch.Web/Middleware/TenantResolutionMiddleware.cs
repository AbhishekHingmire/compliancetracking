namespace RegWatch.Web.Middleware;
public class TenantResolutionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<TenantResolutionMiddleware> _logger;
    public TenantResolutionMiddleware(RequestDelegate next, ILogger<TenantResolutionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        // TODO: resolve tenant from JWT claim / subdomain / cookie
        // var tenantId = context.User.FindFirst("TenantId")?.Value;
        // if (tenantId != null) context.Items["TenantId"] = int.Parse(tenantId);
        await _next(context);
    }
}
public static class TenantResolutionMiddlewareExtensions
{
    public static IApplicationBuilder UseTenantResolution(this IApplicationBuilder app)
        => app.UseMiddleware<TenantResolutionMiddleware>();
}
