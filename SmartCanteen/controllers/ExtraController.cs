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
        public void UpdateExtra(Extra updatedExtra)
        {
            using (var db = new SmartCanteenContext())
            {
                var existingExtra = db.Extras.SingleOrDefault(e => e.ID == updatedExtra.ID);

                if (existingExtra != null)
                {
                    existingExtra.Description = updatedExtra.Description;
                    existingExtra.Price = updatedExtra.Price;
                    existingExtra.Type = updatedExtra.Type;

                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Extra não encontrado.");
                }
            }
        }

        public void DeleteExtra(int extraId)
        {
            using (var db = new SmartCanteenContext())
            {
                var extra = db.Extras.SingleOrDefault(e => e.ID == extraId);

                if (extra != null)
                {
                    db.Extras.Remove(extra);
                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Extra não encontrado.");
                }
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
        public List<Extra> GetAllExtras()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Extras.ToList();
            }      
        }
    }
}
