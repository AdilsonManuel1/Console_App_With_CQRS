using Data;
using System;
using Application.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Application.Command;
using System.Reflection;

class Program
{
    // Main Method
    static async Task Main(String[] args)
    {

        var connString = "Server=localhost;Database=consoleapp;Uid=root;Pwd=;";
        var serviceProvider = new ServiceCollection().AddDbContext<DataContext>(options => options.UseMySql(connString, ServerVersion.AutoDetect(connString)))
                              .AddMediatR(typeof(CriarClienteCommand))
                              .AddScoped<IClienteService, ClienteService>();
        var builder = serviceProvider.BuildServiceProvider();
        var _mediator = builder.GetRequiredService<IMediator>();

        Console.WriteLine("Informe o Seu Nome ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Informe o Seu Nome ");
        string? Telefone = Console.ReadLine();

        var resultado = await _mediator.Send<bool>(new CriarClienteCommand
        {
            Nome = nome,
            Telefone = Telefone
        });
        if (resultado)
            Console.WriteLine("Dados salvos com sucesso!");
        else
            Console.WriteLine("Erro de gravação ");
    }
}