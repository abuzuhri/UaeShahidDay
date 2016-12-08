using System;
using System.Collections.Generic;
using System.IO;
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

        public void DeleteShahid(long Id)
        {
            ShahidRepository.Delete(Id);
            Save();
        }

        public void AddShahid(string name, string fileName)
        {
            Shahid shahid = new Shahid();
            shahid.Name = name;
            shahid.ImageUrl = fileName;
            ShahidRepository.Insert(shahid);
            Save();
        }
    }
}
