using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Data.Entities
{
    [Table("Product")]
    public class Product
    {
        public int Id { set; get; }
        public decimal? Price { set; get; }
        public decimal? OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public bool? IsFeatured { get; set; }


        public List<ProductInCategory>? productInCategories { set; get; }
        public List<OrderDetail>? orderDetails { set; get; }
        public List<Cart>? Carts { get; set; }

        public List<ProductTranslation>? ProductTranslations { get; set; }

        public List<ProductImage>? ProductImages { get; set; }

    }
}
