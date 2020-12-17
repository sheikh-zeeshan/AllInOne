using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Grid.Model.Entities
{
    [Table("tblMovies")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}