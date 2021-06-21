using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Persistence.Database
{
    public class GenreRepository : IGenreService
    {
        private FilmManagementEntities _context;

        public GenreRepository()
        {
            _context = new FilmManagementEntities();
        }

        public List<Genre> GetGenreList()
        {
            return _context.Genre.Include("Film").ToList();
        }
    }
}