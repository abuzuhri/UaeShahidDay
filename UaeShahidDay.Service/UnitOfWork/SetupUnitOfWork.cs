using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaeShahidDay.Data.Entity;

namespace UaeShahidDay.Service.UnitOfWork
{
    public class SetupUnitOfWork : AppBaseUnitOfWork
    {
        public IList<Shahid> getShahidList(string name=null)
        {
            var qry = ShahidRepository.Table;
            if (!string.IsNullOrEmpty(name))
                qry = qry.Where(a => a.Name.Contains(name));


            qry = qry.OrderBy(a => a.ID);
            //PagedList<Employee> list = new PagedList<Employee>(qry, search);
            var list = qry.ToList();

            return list;
        }
    }
}
