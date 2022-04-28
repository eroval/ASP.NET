using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication.Models
{
    public class Picture
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [DisplayName("")]
        public IFormFile ImageFile { get; set; }

        public Picture() {
        
        }
    }
}
