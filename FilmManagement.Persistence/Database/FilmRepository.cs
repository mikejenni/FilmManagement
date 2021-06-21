using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Persistence.Database
{
    public class FilmRepository : IFilmService
    {
        private readonly FilmManagementEntities _context;

        public FilmRepository()
        {
            _context = new FilmManagementEntities();
        }

        public void DeleteFilm(int filmId)
        {
            var film = _context.Film.FirstOrDefault(x => x.Id == filmId);
            if (film != null)
            {
                _context.Film.Remove(film);
                _context.SaveChanges();
            }
        }

        public void EntryFilm(Film film)
        {
            _context.Film.Add(film);
            _context.SaveChanges();
        }

        public List<Film> GetFilmList()
        {
            var results = _context.Film.Include("Genre").ToList();
            
            return results;

            
        }

        public void UpdateFilm(Film film)
        {
            if (film != null)
            {
                _context.Film.AddOrUpdate(film);
                _context.SaveChanges();
            }
        }
    }
}
