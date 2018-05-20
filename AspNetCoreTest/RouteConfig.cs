using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;

namespace AspNetCoreTest
{
    public class RouteConfig
    {
        public RouteConfig(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                app.UseMvcWithDefaultRoute();

                routes.MapRoute(
                    name: "Kars",
                    template: "{controller=Home}/{action=CreateAndShowRecords}/{id?}");

            });
        }

        //var routes = new RouteBuilder(app);
    }
}
