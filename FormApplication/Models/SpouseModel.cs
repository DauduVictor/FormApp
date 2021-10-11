﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormApplication.Models
{
    public class SpouseModel
    {
        public int SpouseId { get; set; }
        public int FormId { get; set; }
        public string Names { get; set; }
        public string GenderType { get; set; }
        public string EmailAddress { get; set; }
        public string Number { get; set; }

    }
}