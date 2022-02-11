using static System.Console;
class Demo2
{
    static void DemoPT1()
    {
         int a = 5;
       
       Adicionar20(ref a);
       
        WriteLine($"O valor de a é {a}!");
    }
    static void DemoPT2()
    {
              {string.Join(",\n ",nomes)}
        ");
        
       var nomes = new string []{"Lucas", "Maria", "Ricardo", "Alice", "Pedro"}; 
        WriteLine("Digite o nome a ser substituido");
        var nome = ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo= ReadLine();

        AlterarNome(nomes, nome, nomeNovo);
        WriteLine($@"A lista de nomes Alterada é: 
         {string.Join(",\n ",nomes)}
        ");

    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }
   static void AlterarNome(string[] nomes, string nome, string nomeNovo)
   {
       for (int i = 0; i < nomes.Length; i++)
       {
           if(nomes[i] == nome)
           {
               nomes[i] = nomeNovo;
           }
       }
   }
    static ref string LocalizarNome(string[] nomes, nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            return ref nomes [i];
        }
        throw new Exception("Nome não encontrado");
    }
    static void Main()
    {
        WriteLine($@"A lista de nomes é: 
         {string.Join(",\n ",nomes)}
        ");
        
       var nomes = new string []{"Lucas", "Maria", "Ricardo", "Alice", "Pedro"}; 
        WriteLine("Digite o nome a ser substituido");
        var nome = ReadLine();
        WriteLine("Digite o nome novo: ");
        var nomeNovo= ReadLine();

       ref var nomeAchado = ref LocalizarNome(nomes, nome);
       
       if(string.IsNullOrWhiteSpace(nomeAchado))
       {
           nomeAchado = nomeNovo;


         WriteLine($@"A lista de nomes Alterada é: 
         {string.Join(",\n ",nomes)}
        ");


       }
        else
        {
            WriteLine("Nome não encontrado");
        }




    }

}