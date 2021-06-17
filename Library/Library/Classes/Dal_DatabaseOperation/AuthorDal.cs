using Library.Classes.Dataset;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation_
{
    class AuthorDal
    {
        public List<AUTHOR> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.AUTHOR.ToList();
            }
        }

        public void Add(AUTHOR author)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(author);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(AUTHOR author)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(author);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(AUTHOR author)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(author);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
