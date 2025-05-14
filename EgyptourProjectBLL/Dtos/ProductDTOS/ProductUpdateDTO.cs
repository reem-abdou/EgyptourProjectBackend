using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.BLL.Dtos.ProductDTO
{
    public class ProductUpdateDTO
    {
        public string ProductCategory { get; set; }
        public long ProductQuantity { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProfileImagePath { get; set; }
    }
}
