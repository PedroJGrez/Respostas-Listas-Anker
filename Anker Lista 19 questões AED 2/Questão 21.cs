class Pessoa
{
    private string nome;
    private string cpf;

    private Pessoa(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }

    // Livro aninhado dentro de Pessoa
    class Livro
    {
        private string titulo;
        private string autor;
        private bool disponivel;

        private Livro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponivel = true;
        }

        // Emprestimo aninhado dentro de Livro (acessa Livro e Pessoa)
        class Emprestimo
        {
            private Livro livro;
            private Pessoa pessoa;
            private string data;

            private Emprestimo(Livro livro, Pessoa pessoa)
            {
                this.livro = livro;
                this.pessoa = pessoa;
                this.data = DateTime.Now.ToString("dd/MM/yyyy");

                // Marca o livro como emprestado
                livro.disponivel = false;
            }

            private string Exibir()
            {
                string status = livro.disponivel ? "Disponível" : "Emprestado";
                return $"[{data}] \"{livro.titulo}\" ({status}) -> {pessoa.nome} (CPF: {pessoa.cpf})";
            }

            static void Main()
            {
                // Criando pessoas
                Pessoa p1 = new Pessoa("Pedro", "111.222.333-00");
                Pessoa p2 = new Pessoa("Anker", "444.555.666-11");

                // Criando livros
                Livro l1 = new Livro("Dom Casmurro", "Machado de Assis");
                Livro l2 = new Livro("O Cortiço", "Aluísio Azevedo");

                // Registrando empréstimos
                Emprestimo e1 = new Emprestimo(l1, p1);
                Emprestimo e2 = new Emprestimo(l2, p2);

                // Exibindo
                Console.WriteLine(e1.Exibir());
                Console.WriteLine(e2.Exibir());
            }
        }
    }
}