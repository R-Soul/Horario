﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Horario.Domain;

namespace Horario.WebUI.Models
{
    public class Persona
    {
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Cita> Citas { get; set; }
    }
}