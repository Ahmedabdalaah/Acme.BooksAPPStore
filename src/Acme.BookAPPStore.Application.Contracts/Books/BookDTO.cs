﻿using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookAPPStore.Books
{
    public class BookDTO : AuditedEntityDto<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
    }
}
