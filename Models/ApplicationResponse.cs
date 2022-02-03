using System;
using System.ComponentModel.DataAnnotations;
namespace MovieCollection.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        // set up foreign key relationship
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage ="Please insert title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please insert year.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Please insert a director.")]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }
    }
}
