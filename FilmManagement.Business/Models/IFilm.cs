using FilmManagement.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Business.Models
{
    public interface IFilm
    {
        int Id { get; set; }
        string TitleName { get; set; }
        string ReleaseYear { get; set; }
        string Director { get; set; }
        string PlayTime { get; set; }
        string Rating { get; set; }
        int? GenreId { get; set; }

        Genre Genre { get; set; }


    }
}
