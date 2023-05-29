// - Приём информации
System.Console.Write("Введите элементы через пробел: ");
string text = Convert.ToString(Console.ReadLine())!;

// - Разделение по пробелу
string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

// - Прохождение по всем элементам
foreach (string rez in words)
{
    // - Поиск слов менее 4 символов
    if (rez.Length < 4)
    {
    // - Вывод интересующих слов   
       Console.Write($"{rez} ");
    }
}
// - отступ вниз по завершении
System.Console.WriteLine("");