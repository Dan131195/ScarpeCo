﻿using Scarpe_Co;

namespace Scarpe_Co.Models
{
    public class Prodotto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string? Descrizione { get; set; }
        public string? ImmagineCopertina { get; set; }
        public string? ImmagineAggiuntiva1 { get; set; }
        public string? ImmagineAggiuntiva2 { get; set; }
        
    }
}
