internal static class ExerciceFixationHelpers
{
    public static void Main()
    {
        /*Exercicio 1: Verificar se um número é primo
        Console.WriteLine("Digite um número:");
        int num = Convert.ToInt32(Console.ReadLine());
        bool ehPrimo = true;

        if (num <= 1)
        {
            ehPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
        }
        if (ehPrimo)
            Console.WriteLine("O número é primo.");
        else
            Console.WriteLine("O número não é primo.");
         */



        /*Exercicio 2: Calcular a soma dos números pares de 1 a 100 
        Console.WriteLine("Digite um numero para saber a soma dos numeros pares dele ate 100:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 != 0) {
            num += 1;
        }
        for (int i= num; i <= 100; i += 2) { 
            Console.WriteLine(i);
        }
        */



        /*Exercicio 3 : Encontrar o maior número em uma lista 
        List<int> listNumber = new List<int>();
        int maior = int.MinValue;

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());
            listNumber.Add(number);
        }

        foreach (int item in listNumber)
        {
            if (item > maior)
            {
                maior = item;
            }
        }

        Console.WriteLine("O maior número é: " + maior)
        }*/



        /*Exercicio 4: Calcular a média de uma lista de números
        int [] listNumber = {10,5,4,6,7,3,1,4};
        int totalList = 0;
        for (int i = 0; i < listNumber.Length; i++)
        {
             totalList += listNumber[i];
        }
        int media = totalList / listNumber.Length;
        Console.WriteLine("A media da Lista e de ${totalList}"); */

        /*Exercicio 5: Contar o número de vogais em uma string
        string input = "Exercicio de fixacao";
        int countVogais = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                countVogais++;
            }
        }*/
    }


}