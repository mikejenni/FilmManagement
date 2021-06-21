using FilmManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Business.Services
{
    public interface IFilmValidatorService
    {
        bool ValidateFilm(IFilm film);
    }
}
