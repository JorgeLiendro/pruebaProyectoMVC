﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.Models
{
    public class Profesion
    {
        [Key]
        public int CodProfesion { get; set; }
        public string Nombre { get; set; }
    }
}
