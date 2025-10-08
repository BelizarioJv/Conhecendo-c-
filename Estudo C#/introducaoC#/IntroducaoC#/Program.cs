namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             If , else e siwtch case
      
            int numero1 = 50;
            int numero2 = 2;
            if (numero1 % numero2 == 0)
            {
                Console.WriteLine($"O número {numero1} é par.");
            }else{
                Console.WriteLine($"O número {numero1} é ímpar.");    

            }
            string cor = "vermelho";
            case (cor){
            case "vermelho":
                    Console.WriteLine("A cor é vermelho");
                    break;
                case "azul":
                    Console.WriteLine("A cor é azul");
                    break;
                default:
                    Console.WriteLine("A cor não é vermelho nem azul");
                    break;
            }
            */


            /*Laços de repetição
             
            for(int i = 0 ; i < 10 ; i++){
                Console.WriteLine(i);
            }



            int j = 10;
            while(j > 0){
                Console.WriteLine(j);
                j--;
             */


            /*Funçao
            void saudaçao(string nome)
            {
                Console.WriteLine($"Olá {nome}, seja bem vindo!");
            }
            saudaçao("Joao");
            */

            /*Array
            string[] frutas = {"maçã", "banana", "laranja"};
            console.WriteLine(frutas[0]);
            foreach(string fruta in frutas){
                Console.WriteLine(fruta);
            }
            */
            /*Array
            string[] frutas = {"maçã", "banana", "laranja"};
            console.WriteLine(frutas[0]);
            foreach(string fruta in frutas){
                Console.WriteLine(fruta);
            }
            */

            /*Orientada a objetos
            class Pessoa
            {
                public string Nome { get; set; }
                public int Idade { get; set; }
                public void Apresentar()
                {
                    Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
                }
            class Car 
                  {
                    string model;
                    string color;
                    int year;

                     public Car(string modelName,carColor,yearCar){
                        
                        model = modelName;
                        color = carColor;
                        year = yearCar;
                     }

                    static void Main(string[] args)
                    {
                      Car Ford = new Car();
                      Ford.model = "Mustang";
                      Ford.color = "red";
                      Ford.year = 1969;

                      Car Opel = new Car("Astra","white";2005;);
              
      
                      Car Gol = new Car();
                      Gol.model = "Gol";
                      Gol.color= "verde";
                      Gol.year = 2002;

                      Console.WriteLine(Ford.model);
                      Console.WriteLine(Opel.model);
                      Console.WriteLine(Gol.model);
                    }
                  }
            */
        }
    }
}