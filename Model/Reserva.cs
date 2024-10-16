namespace DesafioHospedagem.Model;
public class Reserva
{
    public Suite Suite { get; set; }
    public List<Pessoa> Hospedes { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        var temDesconto = DiasReservados > 10;
        var valorDiaria = Suite.ValorDiaria;

        return temDesconto ? valorDiaria - (valorDiaria * 0.1M) : valorDiaria;
    }
}