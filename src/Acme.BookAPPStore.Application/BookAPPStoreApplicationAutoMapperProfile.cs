using Acme.BookAPPStore.Books;
using AutoMapper;

namespace Acme.BookAPPStore;

public class BookAPPStoreApplicationAutoMapperProfile : Profile
{
    public BookAPPStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDTO>();
        CreateMap<CreateUpdateBookDto, Book>();

    }
}
