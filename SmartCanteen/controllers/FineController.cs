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
        /// <exception cref="Exception">Thrown when there is an existing fine with fewer hours and a lower value.</exception>
        public void AddFine(int hour, double value)
        {
            using(var db = new SmartCanteenContext())
            {
                ValidateFine(hour, value, db);

                var fine = new Fine(hour, value);
                db.Fines.Add(fine);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Validates the fine to ensure no existing fine has fewer hours with a lower value.
        /// </summary>
        /// <param name="hour">The number of hours associated with the fine.</param>
        /// <param name="value">The value of the fine.</param>
        /// <param name="db">The database context.</param>
        /// <exception cref="Exception">Thrown when there is an existing fine with fewer hours and a lower value.</exception>
        private void ValidateFine(int hour, double value, SmartCanteenContext db)
        {
            var conflictingFine = db.Fines
                .Where(f => f.NumHours == hour || (f.NumHours < hour && f.Value >= value))
                .FirstOrDefault();

            if (conflictingFine != null)
            {
                throw new Exception("Não é possível adicionar a multa. Já existe uma multa com menos horas e valor menor.");
            }
        }
    }
}
