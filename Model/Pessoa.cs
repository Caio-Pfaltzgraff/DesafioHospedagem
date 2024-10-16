namespace DesafioHospedagem.Model;
public class Pessoa
{
  public string Nome { get; set; }
  public string SobreNome { get; set; }

   public Pessoa(string nome, string sobreNome)
   {
      Nome = nome;
      SobreNome = sobreNome;
   }
}