﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IBreweryDAO
    {
        bool CreateBrewery(BrewerySqlDAO brewery);
    }
}