using ClassRoom_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_10.Services
{
    internal class BookService
    {
        private Book[] GetAll()
        {
            Book book1 = new Book()
            {
                id = 1,
                Name = "Mest1",
                Author = "Mushfiq",
                PageCount = 200

            };

            Book book2 = new Book()
            {
                id = 2,
                Name = "Test2",
                Author = "Nizami",
                PageCount = 550

            };

            Book book3 = new Book()
            {
                id = 3,
                Name = "Test3",
                Author = "Cavid",
                PageCount = 330

            };

            Book book4 = new Book()
            {
                id = 4,
                Name = "Test4",
                Author = "Nizami",
                PageCount = 30

            };

            return new Book[] { book1, book2, book3, book4 };






        }

        public Book[] GetAllByAuthor(string author)
        {
            Book[] books = GetAll();
            Book[] filtredBooks = books.Where(m=>m.Author == author).ToArray();
            return filtredBooks;
        
        }

        public Book GetById(int id) 
        {
            Book[] books = GetAll();
            Book book = books.FirstOrDefault(m => m.id == id);
            return book;
        }

        public Book[] SearchByName(string searchText)
        {
            return GetAll().Where(m => m.Name.ToLower().Contains(searchText.ToLower())).ToArray();
        }
    }
}



//    return new Book[]
//    {
//     new Book
//    }
//     id = 1;
//    Name = "Isgendarname";
//    Author = "Nizami";
//    PageCount = 2000;
//},
//ne Book 
//{
//}