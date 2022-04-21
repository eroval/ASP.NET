﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Picture
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        public Picture() {
        
        }
    }
}