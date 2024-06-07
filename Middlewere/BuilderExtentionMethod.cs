namespace Middlewere
{
    public static class BuilderExtentionMethod
    {
        public static IApplicationBuilder UseLoggerMiddlware(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<LoggerMiddleware>();
        }

        public static IApplicationBuilder UseCustomMiddlware(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<LoggerMiddleware>();
        }

    }
}
