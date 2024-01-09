using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceCabinetAudit : Service<Cabinet_Audit>, IServiceCabinetAudit
    {
        public ServiceCabinetAudit(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int NbrAudit(DateTime date)
        {
            return 2;
        }
    }
}
