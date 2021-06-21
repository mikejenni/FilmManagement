using FilmManagement.Business.Models;
using FilmManagement.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.UI.Models
{
    public class FilmModel : IFilm
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public string ReleaseYear { get; set; }
        public string Director { get; set; }
        public string PlayTime { get; set; }
        public string Rating { get; set; }
        public int? GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        public string GenreName { get; set; }
    }
}
