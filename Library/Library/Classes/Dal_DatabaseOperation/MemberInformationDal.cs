using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Data.Entity;

namespace Library.Classes.Dal_DatabaseOperation
{
    class MemberInformationDal
    {
        //public List<MEMBER> GetAll()
        //{
        //    using (LibraryCONTEXT context = new LibraryCONTEXT())
        //    {
        //        return context.MEMBER.ToList();
        //    }
        //}

        public void Add(MEMBER_INFORMATION memberInformation)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(memberInformation);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        //public void Update(MEMBER member)
        //{
        //    using (LibraryCONTEXT context = new LibraryCONTEXT())
        //    {
        //        var entity = context.Entry(member);
        //        entity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(MEMBER member)
        //{
        //    using (LibraryCONTEXT context = new LibraryCONTEXT())
        //    {
        //        var entity = context.Entry(member);
        //        entity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}
    }
}
