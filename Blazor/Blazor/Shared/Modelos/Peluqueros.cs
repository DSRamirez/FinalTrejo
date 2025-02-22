﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Shared.Modelos
{
    public class Peluqueros
    {
        [Key]
        public int Id_Peluquero { get; set; }
        [Required]
        public string Peluquero { get; set; }
        [Required]
        public DateTime Dia_Y_Horario_Disponible { get; set; }
    }
}
