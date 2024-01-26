using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        ///  <summary>
        /// I added this.
        /// </summary>

        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        //CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();

    }
}
