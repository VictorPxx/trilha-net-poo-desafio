namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementado !!!
        public string Numero { get; set; }
        private string Modelo { get; set; } = string.Empty;
        private string IMEI { get; set; } = string.Empty;
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Implementado !!!
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}