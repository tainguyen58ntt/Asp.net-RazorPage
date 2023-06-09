﻿using System.ComponentModel.DataAnnotations;

namespace RazorWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="display order")]
        [Range(1, 10,ErrorMessage ="just in range 1 - 10")]
        public int DisplayOrder { get; set; }
    }
}
