﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_POSFE.Config
{
    public class UserBE
    {
        public string user { get; set; }
        public byte[] pass { get; set; }
        public byte[] salt { get; set; }
        public UserBE()
        {

        }
    }
}
