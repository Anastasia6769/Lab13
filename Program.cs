// //Шаг 1. Метод без параметров
// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 16 октября 2026 года");
//     Console.WriteLine("0_0");
// }
// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("    Конец программы");
//     Console.WriteLine("X_X");
// }
// //Шаг 2. Метод с параметрами
// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}");
//     Console.WriteLine($"Возраст: {age}");
//     Console.WriteLine($"Группа: {group}");
// }
// PrintStudentCard("Егор", 18 , "1");
// PrintStudentCard("Валерия", 17, "2");
//Шаг 3. Метод, возвращающий значение
double CalculateScholarship(double baseAmount, double bonusPercent) {
    return baseAmount + baseAmount * bonusPercent / 100;
}
bool IsEligibleForBonus(double averageGrade)
{
    return averageGrade >= 4.5;
}
double result;
if (IsEligibleForBonus(5))
{
    result = CalculateScholarship(2000, 15);
}
else
{
    result = CalculateScholarship(2000, 0);
}
Console.WriteLine(result);
//Шаг 4. Массив как параметр
double CalculateAverageGrade(int[] grades) {
    int sum = 0;
    foreach (int grade in grades) {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades) {
    int count = 0;
    foreach (int grade in grades) {
        if (grade == 5) 
        count++;
    }
    return count;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine(fives);
//Шаг 5. Знакомство с перегрузкой методов
// using System.ComponentModel;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(Add(2, 3));
//         Console.WriteLine(Add(2.5, 3.5));
//         Console.WriteLine(Add(2, 3, 4));
//     }
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     static double Add(double a, double b)
//     {
//         return a + b;
//     }
//     static int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }

// }
//Самостоятельные задания ★
//Задача А
void PrintDivider()
{
    Console.WriteLine("------------");
}
Console.WriteLine("Привет!");
PrintDivider();
Console.WriteLine("Как дела?");
PrintDivider();
Console.WriteLine("Пока!");
//Задача Б
void PrintPerson(string name, int age)
{
    Console.WriteLine($"Имя:{name}");
    Console.WriteLine($"Возраст: {age}");
}
PrintPerson("Аня", 16);
PrintPerson("Саша", 19);
PrintPerson("Вика", 20);
//Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
//Вариант 2
static double CalculateArea(double width, double height)
{
    return width * height;
}
Console.WriteLine(CalculateArea(5, 4));
//Вариант 7
static int FindMin(int[] numbers)
{
    return numbers.Min();
}
int[] numbers = { 8, 6, 4, 5 ,6 };
Console.WriteLine(FindMin(numbers));