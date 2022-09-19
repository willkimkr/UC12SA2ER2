namespace CadastroPessoa.Classes
{
    static class Utils
    {

        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine(texto);
            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
            Console.ResetColor();
        }
    }
}