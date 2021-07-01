using Compare.BLL.DTOs.Advertising;
using Compare.BLL.DTOs.Manufacture;
using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.ProductDetailAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Compare.Models
{
    public class ProductViewModel
    {
        public IEnumerable<ProductDTO> ProductDTOs { get; set; }
        public PageViewModel PageViewModel { get; set; }

        public FilterProductList FilterProductList { get; set; }
        public string SearchText { get; set; }

        public IEnumerable<AdvertListDTO> AdvertList { get; set; }
    }

    public class FilterProductList
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }

        public int?[] Brands { get; set; }
        public IEnumerable<ManufactureDTO> Manufactures { get; set; }

        public List<SearchAttribute> Attributes { get; set; }
        public IEnumerable<Facet> FacetList { get; set; }
    }

    public class Facet
    {
        public string Name { get; set; }

        public List<ProductDetailAttributeListDTO> AttributeList { get; set; }
    }
}
