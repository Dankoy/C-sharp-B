﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDerriv1
{
    public class CB : CA
    {
        // Make access for protected method of base class
        public int F3()
        {
            return F2();
        }

        // Method override CA.virtualF4()
        public  override string VirtualF4()
        {
            return "VirtualF4 F4 class CB";
        }
    }
}