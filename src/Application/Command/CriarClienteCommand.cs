using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Application.Service;

namespace Application.Command
{
    public class CriarClienteCommand : IRequest<bool>
    {

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
    }

    public class CriarClienteCommandHandler : IRequestHandler<CriarClienteCommand, bool>
    {
        private readonly IClienteService _clienteService;
        public CriarClienteCommandHandler(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<bool> Handle(CriarClienteCommand command, CancellationToken cancellationToken)
        {
            return await _clienteService.CriarCliente(command.Nome ?? string.Empty, command.Telefone ?? string.Empty);
        }
    }
}