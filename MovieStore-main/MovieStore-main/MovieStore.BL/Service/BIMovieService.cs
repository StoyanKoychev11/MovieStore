﻿using MovieStore.BL.Interface;
using MovieStore.DL.Interfaces;
using MovieStore.Models.Responses;

namespace MovieStore.BL.Service
{
    internal class BlMovieService : IBlMovieService
    {
        private readonly IMovieService _movieService;
        private readonly IActorRepository _actorRepository;

        public BlMovieService(IMovieService movieService, IActorRepository actorRepository)
        {
            _movieService = movieService;
            _actorRepository = actorRepository;
        }

        public List<MovieFullDetailsResponse> GetAllMovieDetails()
        {
            var result = new List<MovieFullDetailsResponse>();

            var movies = _movieService.GetAll();

            foreach (var movie in movies)
            {
                var movieDetails = new MovieFullDetailsResponse();
                movieDetails.Title = movie.Title;
                movieDetails.Year = movie.Year;
                movieDetails.Id = movie.Id;

                foreach (var actorId in movie.Actors)
                {
                    var actor = _actorRepository.GetById(actorId);
                }

            }
            return result;
        }
    }
}
