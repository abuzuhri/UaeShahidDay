using GoTech.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaeShahidDay.Data.Context;
using UaeShahidDay.Data.Entity;

namespace UaeShahidDay.Service.UnitOfWork
{
    public class AppBaseUnitOfWork : BaseGoTechUnitOfWork
    {
        public BaseDataRepository<Shahid> ShahidRepository { get; set; }

        public AppBaseUnitOfWork() : base(new MainContext())
        {
            ShahidRepository = this.Repository<Shahid>();
        }
    }
}
