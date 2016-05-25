using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTracker.Domain
{
    public class Vehicle
    {
        #region Properties

        public int VehicleId { get; set; }

        public String VIN { get; set; }

        public int Year { get; private set; }

        public Maker Make { get; private set; }

        public Model Model { get; private set; }

        public string NickName { get; set; }

        #endregion

        #region Constructors

        public Vehicle()
        {
            VehicleId = 0;
        }

        #endregion


        #region Public Methods

        public void SetYear(int year)
        {
            if (year < 1886)
                throw new ArgumentOutOfRangeException("year", year, "Nice try, Amédée Bollée, but Karl Benz had the first car in 1886.");
            if (year > DateTime.Now.AddYears(1).Year)
                throw new ArgumentOutOfRangeException("year", year, "Woah there Doc Brown, no Mr Fusion vehicles supported.");

            Year = year;
        }

        public void SetMake(Maker make)
        {
            if (make == null)
                throw new ArgumentNullException("make");

            Make = make;
        }

        public void SetModel(Model model)
        {
            if (model == null)
                throw new ArgumentNullException("model");
            if (Make == null)
                throw new ArgumentException("The maker must be set first.");
            if (model.MakerId != Make.Id)
                throw new ArgumentNullException(string.Format("The model {0} does not belong to {1}, frankenstein'ing is bad m'kay.", model.Name, Make.Name));

            this.Model = model;
        }

        #endregion
    }
}
