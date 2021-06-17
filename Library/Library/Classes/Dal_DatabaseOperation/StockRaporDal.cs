using Library.Classes.Dataset;
using Library.Classes.TableClasses;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Library.Classes.Dal_DatabaseOperation
{
    class StockRaporDal
    {
        public List<STOCK_RAPOR> GetAll()
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                return context.STOCK_RAPOR.ToList();
            }
        }

        public void Add(STOCK_RAPOR stockRapor)
        {
            using (LibraryCONTEXT context = new LibraryCONTEXT())
            {
                var entity = context.Entry(stockRapor);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
