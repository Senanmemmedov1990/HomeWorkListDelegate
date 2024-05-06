using HomeWorkLinkedlistDelegate;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

List<Employe> employes = new List<Employe>();

employes.AddRange(new Employe[] {

    new Employe("Ali" , "IT"),
    new Employe("Senan" , "IT"),
    new Employe("Samir" , "Qabyuyan"),
    new Employe("Samid" , "C# developer"),
    new Employe("Nusret" , "Texnik"),
});

Console.WriteLine(employes.Count);

List<Student> students = new List<Student>();
int choice;
do
{
    Console.WriteLine("1) Student Elave et:");
    Console.WriteLine("2) Employe elave et:");
    Console.WriteLine("3) Axtaris et:");
    Console.WriteLine("4-Cixis");

    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            AddStudent();
            break;
        case 2:
            AddEmploye();
            break;
        case 3:
            int choice1;
            do
            {
                Console.WriteLine("1) Employe uzre axtaris");
                Console.WriteLine("2) Student uzre axtaris");
                Console.WriteLine("0) Geriye donue");
                choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        SearchForEmploye();
                        break;
                    case 2:
                        SearchForStudent();
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin");
                        break;
                }
            } while (choice1 != 0);
            break;
        case 4:
            Console.WriteLine("Proqramdan cixildi");
            break;
        default:
            Console.WriteLine("Secimlerden birini sec");
            break;
    }
} while (choice != 4);

void SearchForStudent()
{
    Console.WriteLine("Mingrade daxil edin");
    int mingrade = int.Parse(Console.ReadLine());
    Console.WriteLine("Maxgrade daxil edin");
    int maxgrade = int.Parse(Console.ReadLine());
    List<Student> studentsInRange = students.FindAll(x => x.Grade >= mingrade && x.Grade <= maxgrade);
    Console.WriteLine("Aralıktaki öğrencilerin notları:");
    foreach (Student student in studentsInRange)
    {
        Console.WriteLine($"Student name: {student.Name}, Grade: {student.Grade}");
    }
}

void SearchForEmploye()
{
    Console.WriteLine("Axtaris ucun position daxil et:");
    string pst = Console.ReadLine();

    List<Employe> searchingValues = employes.FindAll(data => data.Position.Equals(pst.Trim() ,StringComparison.InvariantCultureIgnoreCase)).ToList();
   
    if (searchingValues.Count == 0)
    {
        Console.WriteLine("Tapilmadi:(");
    }
    else
    {
        Console.WriteLine($"Tapilan userler sayi --> {searchingValues.Count}");
        foreach (var item in searchingValues)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($@"name : {item.Name}
suranme : {item.Surname}
Age : {item.Age}
position : {item.Position}");
            Console.WriteLine("--------------------------------");
        }
    }
}

(string, string, int) Input()
{
    Console.Write("Adiniz:");
    string name = Console.ReadLine();
    Console.Write("Soyadiniz:");
    string surName = Console.ReadLine();
    Console.Write("Age:");
    int age = int.Parse(Console.ReadLine());
    return (name, surName, age);
}

void AddEmploye()
{
    (string name, string surname, int age) = Input();
    Console.Write("Position:");
    string position = Console.ReadLine();
    Employe employe = new Employe(name, position);
    employe.Age = age;
    employe.Surname = surname;
    employes.Add(employe);
    Console.WriteLine("Isci elave olundu");
}

void AddStudent()
{
    (string name, string surname, int age) = Input();
    Console.WriteLine("Grade:");
    int grade = Convert.ToInt32(Console.ReadLine());
    Student student = new Student(name, grade);
    student.Surname = surname;
    student.Age = age;
    students.Add(student);
    Console.WriteLine("Student elave olundu.");
}