using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.DTOs
{
    public class ProductDTO
    {
        public string Title { get; set; }

        public override bool Equals(Object obj)
        {
            if(null == obj as ProductDTO)
            {
                return false;
            }
            ProductDTO tempObj = (ProductDTO)obj;
            return tempObj.Title.Equals(this.Title);
        }
    }
}
