
 int num1 = int.Parse(Console.ReadLine());
 int num2 = int.Parse(Console.ReadLine());
 int result = SomarNum(num1, num2);
 Console.WriteLine(result);

 static int SomarNum(int n1, int n2)
 {
    return n1 + n2;
 }

// Dúvidas ou pontos que acho legal observar ou relembrar
// Qual a diferença entre Convert.ToInt32() e int.Parse()
// O que um metodo static
// por que não aparece mais static void Main(String[] args) 
// See https://aka.ms/new-console-template for more information
// por que fica esssa linha amarela de aviso quando uso int.Parse
