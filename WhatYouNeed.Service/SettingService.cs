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
    public interface ISettingService : IService<Setting>
    {
    }

    public class SettingService : Service<Setting>, ISettingService
    {
        public SettingService(IRepositoryAsync<Setting> repository)
            : base(repository)
        {
        }
    }
}
