namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string nome, string modelo, string imei, int memoria) : base(nome, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso!");
        }
    }
}