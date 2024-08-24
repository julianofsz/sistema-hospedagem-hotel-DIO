using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem_hotel.Model
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            this.DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("Você não pode cadastrar mais hospedes pois atingiu o limite da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            var QuantidadeDeHospedes = Hospedes.Count();
            return QuantidadeDeHospedes;
        }

        public decimal CalcularValorDaDiaria()
        {
            decimal ValorTotal = DiasReservados * Suite.ValorDiaria;
            if(DiasReservados >= 10)
            {
                ValorTotal *= 0.90M;
            }

            return ValorTotal;           
        }
    }
}