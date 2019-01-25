﻿using System;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace EInfrastructure.Core.AutoFac.MySql.AspNetCore
{
    public class MvcAutoRegister : EInfrastructure.Core.AutoFac.MySql.MvcAutoRegister
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public override IServiceProvider Build(IServiceCollection services,
           Action<ContainerBuilder> action)
        {
            return base.Build(services, (builder) =>
            {
                services.AddMvc().AddControllersAsServices();
                action(builder);
            });
        }
    }
}
