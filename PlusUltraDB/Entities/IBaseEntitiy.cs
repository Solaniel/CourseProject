﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusUltraDB.Entities
{
    public interface IBaseEntitiy<T>
    {
        T Id { get; set; }
    }
}
