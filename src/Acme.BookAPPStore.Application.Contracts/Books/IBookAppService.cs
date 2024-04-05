using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookAPPStore.Books
{
    public interface IBookAppService :
         ICrudAppService< //Defines CRUD methods
        BookDTO, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>//Used to create/update a book
    {

    }
}
