﻿using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using AireSpring.Presenter;
using AireSpring.Service;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;
using Unity.Lifetime;

namespace AireSpring
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = this.AddUnity();

            container.RegisterType<IEmployeeRepository, InMemoryEmployeeRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IEmployeePresenter, EmployeePresenter>();

        }
    }
}