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


        //int a=5
        //deneme
        public DateTime StartDate { get; set; }




        //deneme


        public DateTime FinishDate { get; set; }
        public string CampaignsTitle { get; set; }
        public string CampaignsImage { get; set; }
        public string CampaignsStatement { get; set; }
        //kampanya ürün ilişkisi
        //deneme-campaigns-by irem
        //it is commited
        [ForeignKey("Product")]
        ///deneme
        public int ProductID { get; set; }
        public Product Product { get; set; }
        int a = 1;
        int b = 2;
        //saaaa  ekip


    }
}
