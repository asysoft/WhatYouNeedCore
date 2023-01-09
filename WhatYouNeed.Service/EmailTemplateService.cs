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
    public interface IEmailTemplateService : IService<EmailTemplate>
    {
    }

    public class EmailTemplateService : Service<EmailTemplate>, IEmailTemplateService
    {
        public EmailTemplateService(IRepositoryAsync<EmailTemplate> repository)
            : base(repository)
        {
        }
    }
}
