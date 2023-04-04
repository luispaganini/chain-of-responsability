namespace ChainOfResponsability {
    public class GerenteDiretor : Gerente {
        public override void Aprovar(Pedido pedido) {
            if (pedido.Valor >= 5000) {
                Console.WriteLine("Pedido aprovado pelo diretor.");
            } else if (proximoGerente != null) {
                proximoGerente.Aprovar(pedido);
            }
        }
    }
}
