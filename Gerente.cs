namespace ChainOfResponsability {
    public abstract class Gerente {
        protected Gerente proximoGerente;

        public void DefinirProximo(Gerente proximo) {
            proximoGerente = proximo;
        }

        public abstract void Aprovar(Pedido pedido);
    }
}
