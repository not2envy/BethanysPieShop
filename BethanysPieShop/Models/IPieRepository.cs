﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies(); //gets all the pies
        Pie GetPieById(int pieId);
    }
}
