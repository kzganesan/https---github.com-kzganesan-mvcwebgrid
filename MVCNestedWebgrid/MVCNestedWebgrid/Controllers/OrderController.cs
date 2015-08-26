using MVCNestedWebgrid.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNestedWebgrid.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult List()
        {
            List<OrderVM> allOrder = new List<OrderVM>();

            // here MyDatabaseEntities is our data context
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var o = dc.OrderMasters.OrderByDescending(a => a.OrderID);
                foreach (var i in o)
                {
                    var od = dc.OrderDetails.Where(a => a.OrderID.Equals(i.OrderID)).ToList();
                    allOrder.Add(new OrderVM { order= i, orderDetails = od });
                }
            }
            return View(allOrder);
        }



    }
}
