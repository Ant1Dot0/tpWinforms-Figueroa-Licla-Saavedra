﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Marcas
    {
        public int ID { get; set; }

        public string Marca { get; set; }

        public override string ToString()
        {
            return Marca;
        }

    }
}
