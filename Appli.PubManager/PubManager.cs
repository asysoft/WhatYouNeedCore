using Appli.Service;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli.PubManager
{
    public class PubManager
    {
        IPubLocationsService _PubLocationsService;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public PubManager()
        {

        }
    }
}
