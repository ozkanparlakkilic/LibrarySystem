using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Data.Entity;

namespace Library.Classes.Dal_DatabaseOperation_
{
    class LoginDal
    {
        public void Add(LOGIN login)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(login);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(LOGIN login)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(login);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(LOGIN login)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(login);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
