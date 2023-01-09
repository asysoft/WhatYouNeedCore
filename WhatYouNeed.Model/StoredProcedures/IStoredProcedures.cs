using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli.Model.StoredProcedures
{
    public interface IStoredProcedures
    {
        int UpdateCategoryItemsCount(int categoryID);
    }
}
