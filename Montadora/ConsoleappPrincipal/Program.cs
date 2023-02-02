using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pneu pneu1 = new Pneu(16,150,"Carro de passeio",false);
        
        Pneu pneu2 = new Pneu(16,70,"Pneu de estepe",true);
       
      
        pneu1.Girar(6);

        pneu1.Exibir();

        pneu2.Girar(6);
        pneu2.Girar(100);
        
        Console.WriteLine();
        pneu2.Exibir();

    }


}