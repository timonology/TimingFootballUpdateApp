namespace TimingFootballUpdateTestApp.Backend.Extensions;

public static class CorsPolicyExtensions
{
    public static void ConfigureCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin() // allow any for test sake
                .AllowAnyMethod()
                .AllowAnyHeader());
        });
    }
}
