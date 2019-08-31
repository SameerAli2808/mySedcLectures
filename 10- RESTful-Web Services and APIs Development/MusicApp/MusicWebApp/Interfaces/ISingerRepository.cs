﻿using MusicWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Interfaces
{
    interface ISingerRepository
    {
        IEnumerable<Singer> GetAllSingers();
        Singer GetSinger(int id);
    }
}
