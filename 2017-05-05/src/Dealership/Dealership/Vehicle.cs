﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership
{
    class Vehicle
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }

        public override string ToString()
        {
            return $"VehicleId: {VehicleId}, Make: {Make}, Model: {Model}, Year: {Year},";
        }
    }
}
