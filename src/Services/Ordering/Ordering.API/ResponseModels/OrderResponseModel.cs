using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.API.ResponseModels
{
    public class OrderResponseModel
    {
        public int BuyerId { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
