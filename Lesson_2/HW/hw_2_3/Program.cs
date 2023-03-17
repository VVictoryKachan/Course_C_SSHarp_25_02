//Написать программу, которая принимает на вход цифру обозначающую день недели
// и проверяет явл. ли этот день выходным

void DayOff (int num)
{
    string Info ="не относится к неделе";
    if (num==7 || num == 6) Info = "выходной";
    else if (num<6 && num>0) Info = "рабочий день"; 
    Console.WriteLine($"{num} {Info}");
}
DayOff(int.Parse(Console.ReadLine()!));