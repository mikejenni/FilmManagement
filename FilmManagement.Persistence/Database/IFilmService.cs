using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Persistence.Database
{
    public interface IFilmService
    {
        List<Film> GetFilmList();
        void EntryFilm(Film film);
        void UpdateFilm(Film film);
        void DeleteFilm(int filmId);

    }
}
