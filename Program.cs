
 using main.Models;
class Program {
  public static void Main (string[] args) {
   
    // TODO: Realizar os testes com as classes Nokia e Iphone
    Nokia n = new Nokia("1234", "Nokia", "123", 64);
    Iphone i = new Iphone("6789", "Iphone", "456", 128);

    n.InstalarAplicativo("WhatsApp");
    n.Ligar();
    n.ReceberLigacao();
    
    i.InstalarAplicativo("Instagram");
    i.Ligar();
    i.ReceberLigacao();
   
  }
}