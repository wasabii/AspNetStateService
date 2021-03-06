﻿using Autofac;

using Cogito.Autofac;

namespace AspNetStateService.EntityFrameworkCore.InMemory
{

    public class AssemblyModule : ModuleBase
    {

        protected override void Register(ContainerBuilder builder)
        {
            builder.RegisterModule<AspNetStateService.EntityFrameworkCore.AssemblyModule>();
            builder.RegisterFromAttributes(typeof(AssemblyModule).Assembly);
        }

    }

}
