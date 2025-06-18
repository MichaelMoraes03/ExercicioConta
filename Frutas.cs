namespace ContaBancaria
{
    public class Conta
    {
        public Conta(string id, string titular, decimal saldo)
        {
            if (string.IsNullOrWhiteSpace(titular))
            {
                throw new Exception("Titular inválido!");
            }
            if (saldo < 0)
            {
                throw new Exception("Saldo Inválido!");
            }
            Titular = titular;
            Saldo = saldo;
            Id = id;
        }
        public string Titular { get; private set; }
        private decimal Saldo;
        private string Id;

        public void Deposito(decimal valor)
        {
                        if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido!");
                return;  // Sai do método sem fazer o depósito
            }
            Saldo += valor; Console.WriteLine($"O valor {valor:C} foi depositado com sucesso!");
        }

        public void Sacar(decimal valor)
        {
                        if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido!");
                return;  // Sai do método sem fazer o depósito
            }
            Saldo -= valor; Console.WriteLine($"O valor {valor} foi sacado com sucesso!");
        }
    }
}