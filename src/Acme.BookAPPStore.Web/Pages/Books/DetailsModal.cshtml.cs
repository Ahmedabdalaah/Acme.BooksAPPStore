using Acme.BookAPPStore.Books;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Acme.BookAPPStore.Web.Pages.Books
{
    public class DetailsModel : BookAPPStorePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }

        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public DetailsModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public async Task OnGetAsync()
        {
            var bookDto = await _bookAppService.GetAsync(Id);
            Name = bookDto.Name;
            Type = bookDto.Type;
            PublishDate = bookDto.PublishDate;
            Price = bookDto.Price;
            Book = ObjectMapper.Map<BookDTO, CreateUpdateBookDto>(bookDto);
        }
    }
}
