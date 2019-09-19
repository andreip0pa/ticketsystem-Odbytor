﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    /// <summary>
    /// A class of car.
    /// </summary>
    public class Car: Vehicle
    {
        public override string Licenseplate { get => base.Licenseplate; set => base.Licenseplate = value; }
        public override DateTime Date { get; set; }

        public override double Price(bool BroBiz)
        {
            if (BroBiz == true)
            {
                return 240 * 0.95;
            }
            else
                return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
