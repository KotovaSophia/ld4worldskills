using student;
using reader;

namespace student
{
    class Student
    {
        public string FIO = "unknown",
            Group_number = "unknown";
        int Age = 0;

        public Student(string lastname_in, string group_number, int age)
        {
            FIO = lastname_in;
            Group_number = group_number;
            Age = age;
        }
        public static void Print(string lastname, string num_group, int age) => Console.WriteLine($"Студент {lastname} группы {num_group}.\nВозраст: {age}");
    }
}

namespace reader
{
    class Reader
    {
        public string Number_card = "unknown",
            Faculty = "unknown",
            Number_Phone = "unknown";
        string Fam_name = "unknown",
            Date_of_birthday = "unknown";

        public Reader(string number_card, string faculty, string num_phone, string fam_name, string date_of_birthday)
        {
            Number_card = number_card;
            Faculty = faculty;
            Number_Phone = num_phone;
            Fam_name = fam_name;
            Date_of_birthday = date_of_birthday;
        }

        public static void TakeBook(string fam_name, int count_book) => Console.WriteLine($"{fam_name} взял {count_book} книги.");
        public static void TakeBook(string fam_name, params string[] books)
        {
            Console.Write($"{fam_name} взял книги:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write($" {books[i]}");
            }
            Console.Write(".\n");
        }

        public static void ReturnBook(string fam_name, int count_book) => Console.WriteLine($"{fam_name} вернул {count_book} книги.");
        public static void ReturnBook(string fam_name, params string[] books)
        {
            Console.Write($"{fam_name} вернул книги:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write($" {books[i]}");
            }
            Console.Write(".\n");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        string[] books = { "Приключения", "Словарь", "Энциклопедия" };

        Reader[] readers = new Reader[3];
        readers[0] = new("956Ж", "Технический", "+7769343514", "Сахарова", "07.08.2006");
        readers[1] = new("738С", "Технический", "+7581434692", "Советова", "15.02.2004");
        readers[2] = new("321И", "Технический", "+7456323498", "Ясенева", "26.07.2005");

        Student[] students = new Student[3];
        students[0] = new("Советова А.С.", "22ИТ17", 20);
        students[1] = new("Сахарова М.С.", "23ИТ21", 18);
        students[2] = new("Ясенева Ю.Т.", "21ИТ35", 19);

        Reader.TakeBook(students[1].FIO, books);
        Reader.TakeBook(students[2].FIO, 1);

        Reader.ReturnBook(students[1].FIO, books);
        Reader.ReturnBook(students[0].FIO, 3);
    }
}