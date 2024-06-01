using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCanteen.controllers
{
    internal class ExtraController
    {
        public ExtraController()
        {

        }

        public void AddExtra(string description, ExtraType extraType, double price)
        {
            using (var db = new SmartCanteenContext())
            {
                Extra extra = new Extra(description, extraType, price);
                db.Extras.Add(extra);
                db.SaveChanges();
            }
        }
    }
}
