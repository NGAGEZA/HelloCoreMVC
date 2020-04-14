using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace HelloCoreMVC.Models
{
    public class Product
    {
        [Display(Name = "รหัสสินค้า")]
        public string ProductId  { get; set; }
        [Display(Name = "ชื่อสินค้า")]
        public string ProductName { get; set; }
        [Display(Name = "ราคาสินค้า")]
        public int ProductPrice { get; set; }
    }
}
