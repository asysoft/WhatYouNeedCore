using Appli.Model.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli.Service
{
    public interface IListingStatService : IService<ListingStat>
    {
    }

    public class ListingStatService : Service<ListingStat>, IListingStatService
    {
        public ListingStatService(IRepositoryAsync<ListingStat> repository)
            : base(repository)
        {
        }
    }
}
