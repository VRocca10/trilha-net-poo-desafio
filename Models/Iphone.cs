namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public string Nomeapp { get; set; }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Nomeapp = nomeApp;
            Console.WriteLine($"Instalando o aplicativo \"{Nomeapp}\" no Iphone" );
        }
    }
}