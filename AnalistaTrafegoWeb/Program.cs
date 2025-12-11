namespace AnalistaTrafegoWeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControleAcesso controleAcesso = new ControleAcesso();

            int top = 3;

           var url  =  controleAcesso.UrlMaisVisitadas(top);
           var ips = controleAcesso.IpsSuspeitos();
            var horas = controleAcesso.MaiorVolumeAcesso();

            foreach (var listaUrl in url)
            {
                Console.WriteLine(listaUrl);
            }
            foreach (var listaIps in ips)
            {
                Console.WriteLine(listaIps);
            }
                Console.WriteLine(horas);
        }
    }
}
