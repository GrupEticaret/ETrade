using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Campaigns
    {
        [Key]
        public int CampaignsID { get; set; }
        public double DiscountRatio { get; set; }


        //deneme
        public DateTime StartDate { get; set; }


        //deneme
        //deneme2


        public DateTime FinishDate { get; set; }
        public string CampaignsTitle { get; set; }
        public string CampaignsImage { get; set; }
        //deneme
        public string CampaignsStatement { get; set; }
        //kampanya ürün ilişkisi
        //deneme-campaigns-by irem
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }


    }
}
