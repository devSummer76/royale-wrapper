﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoyaleWrapper.Models {
    public class Location {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCountry { get; set; }
        public string CountryCode { get; set; }
    }
}
