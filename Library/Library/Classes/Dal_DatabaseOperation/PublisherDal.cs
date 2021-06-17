using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation_
{
    class PublisherDal
    {
        public List<PUBLISHER> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.PUBLISHER.ToList();
            }
        }

        public void Add(PUBLISHER publisher)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(publisher);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(PUBLISHER publisher)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(publisher);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(PUBLISHER publisher)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(publisher);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
