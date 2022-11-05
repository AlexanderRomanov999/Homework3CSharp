int num = 0;
int number = GetNumber(num);
bool IsPalindrom = IsPalindromInt(number);
string message = IsPalindrom ? "да" : "нет";
PrintMessage(message);

int GetNumber(int number)
{
    Console.WriteLine("Введите пятизначное число");
    while (true) {
        number = int.Parse(Console.ReadLine());
        if ((number>-10000 && number<10000) || number>99999 || number<-99999) {
            Console.WriteLine("Нужно ввести пятизначное число!");
        }
        else {
            return number;
        }
    }
}

bool IsPalindromInt(int num)
{
    int temp = num;
    int revert = 0;
    while (temp>0)
    {
        revert = (revert*10)+(temp%10);
        temp/=10;
    }
    return revert==num;
}


void PrintMessage (string message)
{
    Console.WriteLine(message);
}