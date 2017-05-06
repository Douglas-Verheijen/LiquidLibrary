//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Liquid.Library.Repositories
//{
//    public class BookRepository
//    {
//        public ICollection<Book> Get()
//        {
//            using (var context = new LibraryEntities())
//            {
//                var data = context.Books.ToList();
//                return data;
//            }
//        }

//        public void Post(Book book)
//        {
//            using (var context = new LibraryEntities())
//            {
//                context.Books.Add(book);
//                context.SaveChanges();
//            }
//        }
//    }
//}
