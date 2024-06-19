using SmartCanteen.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartCanteen.controllers
{
    internal class FineController
    {
        public FineController() { }

        /// <summary>
        /// Adds a fine to the database.
        /// </summary>
        /// <param name="hour">The number of hours associated with the fine.</param>
        /// <param name="value">The value of the fine.</param>
        /// <exception cref="Exception">Thrown when there is an existing fine with the same hours.</exception>
        public void AddFine(int hour, double value)
        {
            using(var db = new SmartCanteenContext())
            {
                ValidateFine(hour, db);

                var fine = new Fine(hour, value);
                db.Fines.Add(fine);
                db.SaveChanges();
            }
        }

        public void UpdateFine(Fine updatedFine)
        {
            using (var db = new SmartCanteenContext())
            {
                var existingFine = db.Fines.SingleOrDefault(f => f.ID == updatedFine.ID);

                if (existingFine != null)
                {
                    existingFine.NumHours = updatedFine.NumHours;
                    existingFine.Value = updatedFine.Value;

                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Multa não encontrado.");
                }
            }
        }

        public void DeleteFine(int fineId)
        {
            using (var db = new SmartCanteenContext())
            {
                var fine = db.Fines.SingleOrDefault(f => f.ID == fineId);

                if (fine != null)
                {
                    db.Fines.Remove(fine);
                    db.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Multa não encontrada.");
                }
            }
        }

        public  List<Fine> GetAllFines()
        {
            using (var db = new SmartCanteenContext())
            {
                return db.Fines.ToList();
            }
        }

        /// <summary>
        /// Validates the fine to ensure no existing fine has fewer hours with a lower value.
        /// </summary>
        /// <param name="hour">The number of hours associated with the fine.</param>
        /// <param name="value">The value of the fine.</param>
        /// <param name="db">The database context.</param>
        /// <exception cref="Exception">Thrown when there is an existing fine with the same hours.</exception>
        private void ValidateFine(int hour, SmartCanteenContext db)
        {
            var conflictingFine = db.Fines
                .Where(f => f.NumHours == hour)
                .FirstOrDefault();

            if (conflictingFine != null)
            {
                throw new Exception("Não é possível adicionar a multa. Já existe uma multa com menos horas e valor menor.");
            }
        }
    }
}
