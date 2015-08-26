using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNestedWebgrid.ViewModel
{
    public class OrderVM
    {
        public OrderMaster order { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}