using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookService : ICrudAppService< //Defines CRUD methods
        BookDto, //Used to show books
        Guid, //Primary Key of the Book Entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto> // Used to create/update a book
    {

    }
}
