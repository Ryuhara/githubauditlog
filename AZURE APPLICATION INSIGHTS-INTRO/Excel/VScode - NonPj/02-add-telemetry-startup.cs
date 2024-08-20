public void ConfigureServices(IServiceCollection services)
{
    services.AddApplicationInsightsTelemtry();

    services.AddControllerWithViews();
}