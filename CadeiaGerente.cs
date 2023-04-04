namespace ChainOfResponsability {
    public class CadeiaGerente {
        private Gerente gerenteInicial;

        public CadeiaGerente() {
            gerenteInicial = new GerenteJunior();
            Gerente gerenteSenior = new GerenteSenior();
            Gerente gerenteDiretor = new GerenteDiretor();

            gerenteInicial.DefinirProximo(gerenteSenior);
            gerenteSenior.DefinirProximo(gerenteDiretor);
        }

        public void AprovarPedido(Pedido pedido) {
            gerenteInicial.Aprovar(pedido);
        }
    }
}
