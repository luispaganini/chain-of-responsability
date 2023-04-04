namespace ChainOfResponsability {
    public class GerenteSenior : Gerente {
        public override void Aprovar(Pedido pedido) {
            if (pedido.Valor >= 1000 && pedido.Valor < 5000) {
                Console.WriteLine("Pedido aprovado pelo gerente senior.");
            } else if (proximoGerente != null) {
                proximoGerente.Aprovar(pedido);
            }
        }
    }
}
