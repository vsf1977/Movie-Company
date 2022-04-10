using Microsoft.AspNetCore.Mvc;
using PruebaPNG.DataAccess;
using PruebaPNG.Models;
using System.Collections.Generic;
using System.Linq;

namespace PruebaPNG.Domain
{
    public class MovieByMultiplexDomainService
    {
        private MovieDbContext _context;
        public MovieByMultiplexDomainService(MovieDbContext movieDbContext)
        {
            _context = movieDbContext;
        }

        public ActionResult<dynamic> GetAll()
        {
            List<Multiplex> multiplex = _context.Multiplex.Where(x => x.State).ToList();
            List<Movie> movies = _context.Movie.Where(x => x.State).ToList();
            List<MovieByMultiplex> movieByMultiplex = _context.MovieByMultiplex.ToList();
            var query = from mbm in movieByMultiplex
                        join mult in multiplex on mbm.MultiplexId equals mult.Id
                        join mov in movies on mbm.MovieId equals mov.Id
                        select new
                        {
                            multiplexName = mult.Name,
                            movieName = mov.Name,
                            schedule = mbm.Schedule
                        };
            List<Response> responseList = new List<Response>(); 
            foreach (var item in query)
            {
                Response response = new Response();
                response.multiplexName = item.multiplexName;
                response.movieName = item.movieName;
                response.schedule = item.schedule.ToShortTimeString();
                responseList.Add(response); 
            }
            return responseList;
        }
    }
}
