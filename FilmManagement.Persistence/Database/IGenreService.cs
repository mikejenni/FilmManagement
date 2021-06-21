using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmManagement.Persistence.Database
{
    public interface IGenreService
    {
        List<Genre> GetGenreList();
    }

}
