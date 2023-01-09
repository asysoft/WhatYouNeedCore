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
    public interface ICustomFieldCategoryService : IService<MetaCategory>
    {
    }

    public class CustomFieldCategoryService : Service<MetaCategory>, ICustomFieldCategoryService
    {
        public CustomFieldCategoryService(IRepositoryAsync<MetaCategory> repository)
            : base(repository)
        {
        }
    }
}
