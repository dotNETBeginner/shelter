using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameShop.Controllers
{
    public class GenreController : Controller
    {
       private readonly IGenres genreobj;

       public GenreController(IGenres _genreobj)
       { genreobj = _genreobj; }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Genres genre)
        { return genreobj.AddGenre(genre); }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Genres> Index()
        { return genreobj.GetAllGenres(); }

        [HttpGet]
        [Route("Details/{Id_Genre}")]
        public Genres Details(int Id_Genre)
        { return genreobj.GetGenreById(Id_Genre); }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody]Genres genre)
        { return genreobj.UpdateGenre(genre); }

        [HttpDelete]
        [Route("Delete/{Id_Genre}")]
        public int Delete(int Id_Genre)
        { return genreobj.DeleteGenre(Id_Genre); }
    }
}
