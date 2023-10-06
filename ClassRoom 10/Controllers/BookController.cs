using ClassRoom_10.Models;
using ClassRoom_10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_10.Controllers
{
    internal class BookController
    {

        private BookService bookService;

        public BookController()
        {
            bookService = new BookService();
            
        }
        public void GetAllByAuthor() 
        {
            string authorName = "Nizami";

            //BookService bookService = new BookService();
            Book[] result = bookService.GetAllByAuthor(authorName);
            foreach ( var item in result )
            {
              Console.WriteLine($"{item.Name} - {item.Author}");
            }
        }

        public void GetById() 
        {
            int id = 2;
            //BookService bookService = new BookService();
            var result = bookService.GetById(id);
            Console.WriteLine(result.Name + " " + result.Author + " " + result.PageCount);

        }

        public void Search()
        {
            var result = bookService.SearchByName("t");
            foreach ( var item in result )
            {
                Console.WriteLine(item.Name);
            }

        }

    

    }
}
