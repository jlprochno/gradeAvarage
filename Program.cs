namespace gradeAvarage;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza digite o nome do aluno: ");
            string name = Console.ReadLine();
        Console.WriteLine("Agora, digite a 1ª nota do aluno:");
            double firstGrade = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 2ª nota do aluno: ");
            double secondGrade = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 3ª nota do aluno: ");
            double thirdGrade = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 4ª nota do aluno: ");
            double fourthGrade = Convert.ToDouble(Console.ReadLine());

        double avarage = (firstGrade + secondGrade + thirdGrade + fourthGrade)/4;

        Console.WriteLine($"A média das notas do aluno {name} é de {avarage:f2}.");

        if(avarage >= 70.0){
            Console.WriteLine($"Aluno {name}, foi aprovado!");
        }
        else if(avarage > 67.0){
            Console.WriteLine($"Aluno {name}, foi aprovado por conselho de classe!");
        }        
        else if(avarage > 40.0){
            Console.WriteLine($"Aluno {name}, está em recuperação!");
        }
        else Console.WriteLine($"Aluno {name}, foi reprovado!");
    }

}
