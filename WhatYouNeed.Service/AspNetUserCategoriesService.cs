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

    public interface IAspNetUserCategoriesService : IService<UserCategory>
    {

    }

    public class AspNetUserCategoriesService : Service<UserCategory>, IAspNetUserCategoriesService
    {
        public AspNetUserCategoriesService(IRepositoryAsync<UserCategory> repository)
            : base(repository)
        {
        }
    }

}