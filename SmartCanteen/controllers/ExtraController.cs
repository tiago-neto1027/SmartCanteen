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

        public List<Extra> ActiveExtrasByType(ExtraType extraType)
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Extras.Where(e => e.Active && e.Type == extraType).ToList();
            }
        }

        public List<Extra> ActiveExtras()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Extras.Where(e => e.Active).ToList();
            }
        }

        //listing for dataGrid
        public List<Extra> GetAllExtras()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Extras.ToList();
            }      
        }

        public void UpdateExtra(Extra updatedExtra)
        {
            using (var db = new SmartCanteenContext())
            {
                var existingExtra = db.Extras.SingleOrDefault(e => e.ID == updatedExtra.ID);

                if (existingExtra == null)
                {
                    throw new InvalidOperationException("Extra não encontrado.");
                }

                // properties
                existingExtra.Description = updatedExtra.Description;
                existingExtra.Price = updatedExtra.Price;
                existingExtra.Type = updatedExtra.Type;

                db.SaveChanges();
            }
        }
    }
}
