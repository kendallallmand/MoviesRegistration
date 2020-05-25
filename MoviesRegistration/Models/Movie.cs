using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRegistration.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Must be less than 50 characters!")]
        public string Title { get; set; }
        public string Genre { get; set; }

        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

        public Movie()
        {

        }

        public Movie(int ID, string Title, string Genre, int Year, string Actors, string Directors)
        {
            this.ID = ID;
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.Actors = Actors;
            this.Directors = Directors;
        }
    }

    
}
