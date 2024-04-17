﻿using Autofac;
using DI_Autofac;

var container = ContainerConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
    var app = scope.Resolve<IApplication>();
    app.Run();

}

Console.Read();
