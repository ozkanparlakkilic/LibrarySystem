using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation
{
    class LoanDal
    {
        public List<LOAN> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.LOAN.ToList();
            }
        }

        public void Add(LOAN loan)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(loan);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(LOAN loan)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(loan);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(LOAN loan)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(loan);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
