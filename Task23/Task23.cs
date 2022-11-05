int N = 0;
int number = GetNumber(N);
PrintCubes(number);

int GetNumber(int number)
{
    Console.WriteLine("Введите число N");
    number = int.Parse(Console.ReadLine());
    return number;
}

void PrintCubes(int N)
{
    for (int i = 1; i <= N; i++)
    {
        if (i == N) {
            Console.Write(i*i*i);

        }
        else {
            Console.Write(i*i*i+", ");         
        }    
    }
}