using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Payment
    {
        public int Id { get; set; }    
        public int Price { get; set; }
        public string PaymentType { get; set; }
        public int Deposit { get; set; }
    }
}