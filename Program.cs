using DesafioHospedagem.Model;

var suite = new Suite("Premium", 3, 200M);

var p1 = new Pessoa("Caio", "Pfaltzgraff");
var p2 = new Pessoa("Letícia", "Pfaltzgraff");
var p3 = new Pessoa("Ruan", "Pfaltzgraff");

var hospedes = new List<Pessoa>([p1, p2, p3]);

var reserva = new Reserva();

reserva.CadastrarHospedes(hospedes);
reserva.CadastrarSuite(suite);
reserva.DiasReservados = 11;
Console.WriteLine(reserva.ObterQuantidadeHospedes());
Console.WriteLine(reserva.CalcularValorDiaria());