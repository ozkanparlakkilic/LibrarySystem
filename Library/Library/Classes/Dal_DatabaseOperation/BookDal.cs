using Library.Classes.Dataset;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation_
{
    class BookDal
    {
        public List<BOOK> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.BOOK.ToList();
            }
        }

        public void Add(BOOK book)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(BOOK book)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(BOOK book)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
