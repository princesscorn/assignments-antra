namespace ConsoleApp1
{
    public class Startup
    {
        // We will use this method to do the denpendency injection
        public void ConfigureServices (IServiceCollection service)
        {
        }
        // It will be used to work with middleware and environment related thing
        // development env/testing(QA/stagging) env/production env
        public void Configure (IApplicationBuilder appBuilder, IWebHostEnvironment env)
        {
            appBuilder.UseRouting ();   // Middleware

            appBuilder.UseEndpoints(endpoints => {
                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsync("Congratulations! Convention from Console App to Web App!");
                });
            });
        }
    }
}
