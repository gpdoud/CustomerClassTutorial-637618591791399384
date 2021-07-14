﻿using System;
using System.Collections.Generic;
using System.Text;

    /*
     * Properties:
     *  Id int
     *  Name string
     *  City string
     *  State string
     *  Sales decimal
     *  Active bool
     */

namespace CustomerClassTutorial {

    class Customer {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; }
        public bool Active { get; set; } = true;

        private static int LastId { get; set; } = 0;

        public void AddSales(decimal amount) {
            Sales = Sales + amount;
        }

        public Customer(string name, string city = "Cincinnati", string state = "OH") {
            this.Name = name;
            this.City = city;
            this.State = state;
            LastId++;
            this.Id = LastId;
        }
    }
}
