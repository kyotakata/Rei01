﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei01.Buhin
{
    internal interface IBuhin
    {
        int Id { get; }
        int ParentId { get; }
        string Name { get; }
        int Lebel { get; }

        void Execute();
        void Add(IBuhin buhin);

    }
}
