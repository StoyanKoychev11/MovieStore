﻿using Microsoft.Extensions.DependencyInjection;
using MovieStore.DL.Interfaces;
using MovieStore.DL.Repositories;

namespace MovieStore.DL
{
    public static class DependencyInjection
    {
        public static IServiceCollection 
            AddDataDependencies(
                this IServiceCollection services)
        {
            services.AddSingleton<IMovieRepository, MovieStaticRepository>();
            services.AddSingleton<IActorRepository, ActorStaticRepository>();

            return services;
        }
    }
}
