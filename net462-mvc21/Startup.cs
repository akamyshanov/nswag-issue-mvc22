using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace NSwagIssue
{
    public class ValuesController : ControllerBase
    {
        [HttpGet, Route("values")]
        public string[] GetValues() => new[] {"hello", "world"};
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerDocument();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseSwagger();
        }
    }
}