using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation
{
    class MemberDal
    {
        public List<MEMBER> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.MEMBER.ToList();
            }
        }

        public void Add(MEMBER member)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(member);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(MEMBER member)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(member);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(MEMBER member)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(member);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
