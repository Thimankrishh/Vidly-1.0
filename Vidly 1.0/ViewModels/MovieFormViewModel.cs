using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_1._0.Models;

namespace Vidly_1._0.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Display(Name = "Genre")]
        [Required]
        public byte? GenresId { get; set; }


        [Required]
        [Display(Name = "Released Date")]
        public DateTime? ReleasedDate { get; set; }


        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stocks")]
        public int? NumberInStocks { get; set; }


        public IEnumerable<Genres> Genre { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.GenresId;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStocks = movie.NumberInStocks;
            GenresId = movie.GenresId;
        }
    }

   
}