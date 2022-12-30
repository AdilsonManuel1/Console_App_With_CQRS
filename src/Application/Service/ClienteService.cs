using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Entity;

namespace Application.Service
{
    public interface IClienteService
    {
        Task<bool> CriarCliente(string nome, string telefone);
    }

    public class ClienteService : BaseService, IClienteService
    {
        public ClienteService(DataContext dataContext) : base(dataContext) { }
        public async Task<bool> CriarCliente(string nome, string telefone)
        {
            if (_dataContext.Clientes == null)
                throw new Exception("Erro ao criar o cliente");

            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Telefone = telefone
            };
            await _dataContext.Clientes.AddAsync(cliente);
            var r = await _dataContext.SaveChangesAsync();
            if (r > 0)
                return true;
            return false;
        }
    }
}