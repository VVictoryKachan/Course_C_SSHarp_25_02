// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


int Proizved(int num){
int all_pr=1;
for(int i = 1 ; i<=num; i++)
all_pr *= i;

return all_pr;
}

int A = int.Parse(Console.ReadLine()!);
int result = Proizved(A);
Console.WriteLine(result);
