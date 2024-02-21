
//string name1 = "Emiraslan";
//string surname1 = "Miriyev";
//int age1 = 33;

//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;

//string name3 = "Elmir";
//string surname3 = "Qafarzade";
//int age3 = 21;

//Console.WriteLine($"{name2} {surname2} {age2}");

//var stu1 = new
//{
//    name = "Emiraslan",
//    surname = "Miriyev",
//    age = 33
//};

//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22
//};

//Console.WriteLine(stu1);
//Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age);





using Class_Object_Constructor;

Student stu1 = new Student();

stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.address = "Ehmedli";

Student stu2 = new();

stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 70;
stu2.address = "Xetai";
stu2.phone = "1234567890";

string fullName = stu2.name + " " + stu2.surname;

//Console.WriteLine(fullName);

Student stu3 = new()
{
    name = "Sirac",
    surname = "Memmedov",
    age = 22,
    address = "Masazir",
    phone = "23133132131"
};

//Console.WriteLine(stu3.GetFullName());

//var result = stu2.GetFullDatas();
//Console.WriteLine(result);

//Student[] students = { stu1, stu2, stu3 };

//void ShowAll(Student[] datas)
//{
//    foreach (Student item in datas)
//    {
//        Console.WriteLine(item.GetFullDatas());

//    }
//}

//ShowAll(students);

Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    Student foundStudent = new();

//    foreach (var item in datas)
//    {
//        if (item.age == age)
//        {
//            foundStudent = item;
//        }
//    }
//    return foundStudent;
//}

//Student GetByAge(Student[] datas, int age)
//{
//    var result = datas.FirstOrDefault(m => m.age == age);
//    return result != null ? result : new Student();
//}

//Student GetByAge(Student[] datas, int age) => datas.FirstOrDefault(m => m.age == age);


//var result = GetByAge(students, 27);

//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data notfound");
//}



//int a = 7;

//Console.WriteLine(a == 5 ? a.ToString() : "deyil");

//var result = a == 5 ? a.ToString() : "deyil";


//Book book = new Book("Elmir");

//Console.WriteLine(book.name);

//Console.WriteLine(book.name + " " + book.author);
