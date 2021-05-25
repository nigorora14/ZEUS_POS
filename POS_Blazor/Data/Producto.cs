﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_Blazor.Data
{
    public class Producto
    {
        public string IdPro { get; set; }
        public string Idprovee { get; set; }
        public string DescripcionLarga { get; set; }
        public float? Frank { get; set; }
        public float PreCompraS { get; set; }
        public float PreCompra { get; set; }
        public float StockActual { get; set; }
        public int IdCat { get; set; }
        public int IdMarca { get; set; }
        public string Foto { get; set; }
        public float PreVntaxMenor { get; set; }
        public float PreVntaxMayor { get; set; }
        public float PreVntadolar { get; set; }
        public string UndMedida { get; set; }
        public float? PesoUnit { get; set; }
        public float? UtilidadUnit { get; set; }
        public string TipoProdcto { get; set; }
        public float? ValorPorCant { get; set; }
        public string EstadoPro { get; set; }
        public DateTime? FechaCreaProServ { get; set; }
    }
}
