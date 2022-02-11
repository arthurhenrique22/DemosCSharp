using static System.Console;

Pessoa p1 = new Pessoa();
p1.Nome = "Arthur";
p1.Idade = 17;
p1.EnderecoPessoa = new Pessoa.Endereco()
{
    Logradouro= "Rua teste",
    Numero = 300,
    CEP = "00000",
    Cidade = "Pernambuco",
};

WriteLine("Fim");