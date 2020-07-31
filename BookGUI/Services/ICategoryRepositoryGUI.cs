using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public interface ICategoryRepositoryGUI
    {
        IEnumerable<CategoryDto> GetCategoryDtos();
        CategoryDto GetCategoryById(int categoryId);
        IEnumerable<BookDto> GetAllBooksForCategory(int CategoryId);
        IEnumerable<CategoryDto> GetAllCategoryOfABook(int bookId);
    }
}
