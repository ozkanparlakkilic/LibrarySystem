using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation
{
    class PunishmentDal
    {
        public List<PUNISHMENT> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.PUNISHMENT.ToList();
            }
        }

        public void Add(PUNISHMENT punishment)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(punishment);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(PUNISHMENT punishment)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(punishment);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(PUNISHMENT punishment)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(punishment);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
