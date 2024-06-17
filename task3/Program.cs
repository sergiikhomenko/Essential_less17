namespace task3;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Використовуючи динамічні та анонімні типи даних, створіть Англо-Російський
 * словник на 10 слів та виведіть на екран його зміст. 
 */
class Program
{
    static void Main(string[] args)
    {
        List<dynamic> words = new List<dynamic>
        {
            new {English = "apple", Ukrainian = "яблуко"},
            new {English = "book", Ukrainian = "книга"},
            new {English = "cat", Ukrainian = "кіт"},
            new {English = "dog", Ukrainian = "собака"},
            new {English = "elephant", Ukrainian = "слон"},
            new {English = "flower", Ukrainian = "квітка"},
            new {English = "house", Ukrainian = "дім"},
            new {English = "ice", Ukrainian = "лід"},
            new {English = "juice", Ukrainian = "сік"},
            new {English = "kite", Ukrainian = "повітряний змій"},
        };
        foreach (var word in words)
        {
            Console.WriteLine(word.ToString());
        }
    }
}