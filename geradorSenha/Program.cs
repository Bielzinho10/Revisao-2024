using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Alterando a cor do texto para verde (para indicar o início do programa)
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Digite o tamanho da senha que deseja gerar (mínimo 6, máximo 128):");

        // Alterando a cor do texto para o padrão (cinza claro)
        Console.ResetColor();

        // Validando a entrada do usuário
        if (!int.TryParse(Console.ReadLine(), out int tamanhosenha) || tamanhosenha < 6 || tamanhosenha > 128)
        {
            // Mudando a cor do texto para vermelho (para erros)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Por favor, insira um valor válido entre 6 e 128.");
            Console.ResetColor();
            return; // Sai da execução caso o valor não seja válido.
        }

        // Gerando e exibindo a senha
        string senha = GerarSenha(tamanhosenha);

        // Mudando a cor do texto para azul (para indicar a senha gerada)
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Senha gerada: " + senha);
        Console.ResetColor();
    }

    static string GerarSenha(int tamanho)
    {
        // Caracteres possíveis para a senha
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%¨&*";
        Random random = new Random();  // Utilizando Random sem semente específica

        // Usando StringBuilder para melhorar a performance ao concatenar
        StringBuilder senha = new StringBuilder(tamanho);

        for (int i = 0; i < tamanho; i++)
        {
            // Seleciona um índice aleatório entre os caracteres possíveis
            int indiceAleatorio = random.Next(caracteres.Length);
            senha.Append(caracteres[indiceAleatorio]);
        }

        return senha.ToString();
    }
}



