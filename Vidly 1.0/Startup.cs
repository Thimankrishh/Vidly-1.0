﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_1._0.Startup))]
namespace Vidly_1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
