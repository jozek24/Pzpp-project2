﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OSKManager.Model
{
    public class Administrator : User
    {
        public string PhotoPath { get; set; }
    }
}
