using System.Reflection.Metadata.Ecma335;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO Extra: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // Implementado verificação se a quantidade de hóspedes for igual a zero (0) retorna uma excessão.
            if (hospedes.Count == 0)
            {
                throw new Exception ("É necessário que tenha ao menos um hóspede seja acomodado na suíte.");
            }
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // Implementado se a quantidade de hóspedes for menor ou igual a capacidade, então reserva pode ser feita.
            else if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // Implementado excessão ao exceder o limite de hóspedes na suíte.
                throw new Exception ("A quantidade de hóspedes é maior que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // Implementado o retorno da quantidade de hóspedes.
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // Implementado cálculo do valor das diárias pelos dias reservados.
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // Implementado condição, caso reserva seja maior ou igual 10 dias receber desconto de 10%.
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria) - ((DiasReservados * Suite.ValorDiaria) * 0.10M);
            }

            return valor;
        }
    }
}