﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRegistration.Models
{
    public class RentMovie
    {



        public int ID { get; set; }
        public double Qty { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int RunTime { get; set; }
        public double RentalCost { get; set; }


        public RentMovie()
        {
            RentalCost = 6.99;
        }

        public RentMovie(int Id, double Qty, string Title, string Genre, int Year, int RunTime, double RentalCost)
        {
            this.ID = Id;
            this.Qty = Qty;
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.RunTime = RunTime;
            this.RentalCost = RentalCost;
        }

    }
}
