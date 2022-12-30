using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ClientesDTO
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
    }
}