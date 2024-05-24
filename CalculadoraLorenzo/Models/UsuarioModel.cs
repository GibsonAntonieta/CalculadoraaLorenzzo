﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLorenzo.Models
{
    public class UsuarioModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UsuarioModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
