using Acme.BookAPPStore.Books;
using AutoMapper;

namespace Acme.BookAPPStore.Web;

public class BookAPPStoreWebAutoMapperProfile : Profile
{
    public BookAPPStoreWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<BookDTO, CreateUpdateBookDto>();

    }
}
