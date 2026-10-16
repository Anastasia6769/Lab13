//Шаг 1. Метод без параметров
PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("Дата формирования отчёта: 16 октября 2026 года");
    Console.WriteLine("0_0");
}
void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("    Конец программы");
    Console.WriteLine("X_X");
}
//Шаг 2. Метод с параметрами
void PrintStudentCard(string name, int age, string group) {
    Console.WriteLine($"Студент: {name}");
    Console.WriteLine($"Возраст: {age}");
    Console.WriteLine($"Группа: {group}");
}
PrintStudentCard("Егор", 18 , "1");
PrintStudentCard("Валерия", 17, "2");
//