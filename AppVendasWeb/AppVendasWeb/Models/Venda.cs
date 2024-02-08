﻿using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }
        [Display(Name = "Valor total")]

        public decimal ValorTotal { get; set; }
        [Display(Name = "Nota Fiscal")]

        public int NotaFiscal { get; set; }
        [Display(Name = "Cliente")]

        public Guid ClientId { get; set; }

        public Cliente? Cliente { get; set; }
    }
}
