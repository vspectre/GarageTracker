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
            this.VehicleId = 0;
        }

        #endregion


        #region Public Methods

        public void SetYear(int year)
        {
            if (year < 1886)
                throw new ArgumentOutOfRangeException("year", year, "Nice try, Amédée Bollée, but Karl Benz had the first car in 1886.");
            if (year > DateTime.Now.AddYears(1).Year)
                throw new ArgumentOutOfRangeException("year", year, "Woah there Doc Brown, no Mr Fusion vehicles supported.");

            this.Year = year;
        }

        public void SetMake(Maker make)
        {
            if (make == null)
                throw new ArgumentNullException("make");

            this.Make = make;
        }

        public void SetModel(Model model)
        {
            if (model == null)
                throw new ArgumentNullException("model");
            if (this.Make == null)
                throw new ArgumentException("The maker must be set first.");
            if (model.MakerId != this.Make.Id)
                throw new ArgumentNullException(String.Format("The model {0} does not belong to {1}, frankenstein'ing is bad m'kay.", model.Name, this.Make.Name));

            this.Model = model;
        }

        #endregion
    }
}
