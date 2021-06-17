using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation_
{
    class PersonelDal
    {
        public List<PERSONEL> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.PERSONEL.ToList();
            }
        }

        public void Add(PERSONEL personel)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(personel);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(PERSONEL personel)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(personel);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(PERSONEL personel)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(personel);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
