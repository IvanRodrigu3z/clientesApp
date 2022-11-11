using System;
using System.Collections.Generic;

namespace ClientesApp.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
