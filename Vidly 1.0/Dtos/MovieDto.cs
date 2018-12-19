using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_1._0.Models;


namespace Vidly_1._0.Dtos
{
    public class MovieDto 
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Required]
        public byte GenresId { get; set; }

        public DateTime DateAdded { get; set; }

        
        public DateTime ReleasedDate { get; set; }

        
        [Range(1, 20)]
        public int NumberInStocks { get; set; }
    }
}