// Representa um contato da agenda
class Contato
{
    private string nome;
    private string telefone;

    private Contato(string nome, string telefone)
    {
        this.nome = nome;
        this.telefone = telefone;
    }

    // Cria e retorna um novo contato
    private static Contato Criar(string nome, string telefone)
    {
        return new Contato(nome, telefone);
    }

    // Exibe os dados do contato formatados
    private string Exibir()
    {
        return $"Nome: {nome} | Tel: {telefone}";
    }

    // Agenda aninhada dentro de Contato para acessar os membros privados
    class Agenda
    {
        private List<Contato> lista = new List<Contato>();

        // Adiciona um contato na lista
        private void Adicionar(string nome, string tel)
        {
            lista.Add(Contato.Criar(nome, tel));
            Console.WriteLine($"Contato '{nome}' adicionado.");
        }

        // Mostra todos os contatos
        private void Listar()
        {
            Console.WriteLine("\n--- Agenda ---");
            foreach (Contato c in lista)
                Console.WriteLine(c.Exibir());
            Console.WriteLine("--------------\n");
        }

        // Remove contato pelo nome
        private void Remover(string nome)
        {
            Contato encontrado = null;
            foreach (Contato c in lista)
                if (c.nome == nome) encontrado = c;

            if (encontrado != null)
            {
                lista.Remove(encontrado);
                Console.WriteLine($"Contato '{nome}' removido.");
            }
        }

        private static void Main()
        {
            Agenda agenda = new Agenda();

            agenda.Adicionar("Pedro", "27 9111-2222");
            agenda.Adicionar("Anker", "27 9333-4444");
            agenda.Adicionar("Giulio", "27 9555-6666");

            agenda.Listar();

            agenda.Remover("Pedro");

            agenda.Listar();
        }
    }
}