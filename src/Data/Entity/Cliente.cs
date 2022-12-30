using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }

    }
}