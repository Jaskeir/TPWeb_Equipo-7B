﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int CP { get; set; }
    }
}