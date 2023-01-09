using Appli.Model.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli.Model.Models
{
    public partial class AppliContext : IStoredProcedures
    {
        public int UpdateCategoryItemsCount(int categoryID)
        {
            return Database.ExecuteSqlCommand("UPDATE CategoryStats SET COUNT = COUNT + 1 WHERE CategoryID = @p0", categoryID);
        }
    }
}
