using System.Diagnostics;
using hospedagem_hotel.Model;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Ronaldo", sobrenome: "Fenomeno");
Pessoa p2 = new Pessoa(nome: "Roberto", sobrenome: "Carlos");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 1500);

Reserva reserva = new Reserva(diasReservados: 6);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDaDiaria()}");