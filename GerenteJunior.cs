namespace ChainOfResponsability {
    public class GerenteJunior : Gerente {
        public override void Aprovar(Pedido pedido) {
            if (pedido.Valor < 1000) {
                Console.WriteLine("Pedido aprovado pelo gerente junior.");
            } else if (proximoGerente != null) {
                proximoGerente.Aprovar(pedido);
            }
        }
    }
}
