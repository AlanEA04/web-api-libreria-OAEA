﻿using System;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Net.NetworkInformation;

namespace ChambaOAEA.Datos.Modelo
{
    public class Book
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }

        public int? Rate { get; set; }

        public string Genero { get; set; }

        public string Autor { get; set; }

        public string CoverUrl { get; set; }
        
        public DateTime dateTime { get; set; }
    }
}
