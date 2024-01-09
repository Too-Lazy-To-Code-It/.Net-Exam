using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceDetailAudit : Service<DetailsAudit>, IServiceDetailAudit
    {
        public ServiceDetailAudit(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
