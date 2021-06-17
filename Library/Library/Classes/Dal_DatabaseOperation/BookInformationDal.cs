using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation
{
    class BookInformationDal
    {
        public List<BOOK_INFORMATION> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.BOOK_INFORMATION.ToList();
            }
        }

        public void Add(BOOK_INFORMATION bookInformation)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(bookInformation);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(BOOK_INFORMATION bookInformation)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(bookInformation);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(BOOK_INFORMATION bookInformation)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(bookInformation);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
