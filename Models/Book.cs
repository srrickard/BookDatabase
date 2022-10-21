using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDatabase.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        //[Display(Name = "Authors (separate multiple authors with commas)")]
        public string? Authors { get; set; }
        public string? ISBN { get; set; }
        [Display(Name = "Number of Pages")]
        public int? NumberOfPages { get; set; }
        //[Display(Name = "Genres (separate multiple genres with commas)")]
        public string? Genres { get; set; }
        public string? Publisher { get; set; }
        [Display(Name = "Date Published")]
        [DataType(DataType.Date)]
        public DateTime? DatePublished { get; set; }
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Date Read")]
        [DataType(DataType.Date)]
        public DateTime? DateRead { get; set; }
        public string? Language { get; set; }
        [Display(Name = "Have Read")]
        public bool? IsRead { get; set; }
        public int? Rating { get; set; }
        public string? Comments { get; set; }
        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }
    }
}
