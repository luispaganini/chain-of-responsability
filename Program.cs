using ChainOfResponsability;

public class Program {
    public static void Main(string[] args) {
        CadeiaGerente cadeia = new CadeiaGerente();

        Pedido pedido1 = new Pedido() { Valor = 500 };
        Pedido pedido2 = new Pedido() { Valor = 2500 };
        Pedido pedido3 = new Pedido() { Valor = 10000 };

        cadeia.AprovarPedido(pedido1);
        cadeia.AprovarPedido(pedido2);
        cadeia.AprovarPedido(pedido3);

        Console.ReadKey();
    }
}