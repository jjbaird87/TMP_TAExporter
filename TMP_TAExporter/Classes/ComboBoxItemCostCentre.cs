using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMP_TAExporter.Classes
{
    public class ComboBoxItemCostCentre
    {
        public override string ToString()
        {
            return $"{ItemObject.Description} ({ItemObject.Code})";
        }

        public CostCentre ItemObject { get; set; }
    }

    public class ComboBoxItemDepartment
    {
        public override string ToString()
        {
            return $"{ItemObject.Description} ({ItemObject.Code})";
        }

        public Department ItemObject { get; set; }
    }

    public class ComboBoxItemCompany
    {
        public override string ToString()
        {
            return $"{ItemObject.Description} ({ItemObject.Code})";
        }

        public Company ItemObject { get; set; }
    }
}
