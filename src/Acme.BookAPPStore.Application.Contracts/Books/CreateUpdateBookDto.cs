﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookAPPStore.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public BookType Type { get; set; } = BookType.undefined;
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;
        [Required]
        public float Price { get; set; }
    }
}
