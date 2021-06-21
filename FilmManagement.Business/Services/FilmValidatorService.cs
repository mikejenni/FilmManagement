using FilmManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Business.Services
{
    public class FilmValidatorService : IFilmValidatorService
    {
        public bool ValidateFilm(IFilm film)
        {
            if (string.IsNullOrEmpty(film.Director) ||
                string.IsNullOrEmpty(film.PlayTime) ||
                string.IsNullOrEmpty(film.Rating) ||
                string.IsNullOrEmpty(film.ReleaseYear) ||
                string.IsNullOrEmpty(film.TitleName))
            {

                return false;
            }

            return true;
        }

    }
}
