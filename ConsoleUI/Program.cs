using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.Identity.Client;

Course csharp = new Course();
Course java = new Course();
Course dotNet = new Course();
Course algoritma = new Course();
Course Sql = new Course();
Course Flutter = new Course();


csharp.Name = "C-Sharp";
csharp.Description = "3 Aylık C-Sharp Kursu.";
csharp.CategoryId = 1;
csharp.Price = 50;


java.Name = "Java Full Stack";
java.Description = "3 Aylık Java Kursu.";
java.CategoryId = 1;
java.Price = 50;


dotNet.Name = "Dot-Net Full Stack";
dotNet.Description = "6 Aylık Dotnet Kursu.";
dotNet.CategoryId = 1;
dotNet.Price = 100;

algoritma.Name = "Algoritma Beginner";
algoritma.Description = "15 Günlük Yazılıma Başlangıç Kursu";
algoritma.CategoryId = 1;
algoritma.Price = 15;

Sql.Name = "MSSQL Veritabanı";
Sql.Description = "İrem Balcıyla 250 SQL Sorgusu";
Sql.CategoryId = 3;
Sql.Price = 15;

Flutter.Name = "flutter Mobil";
Flutter.Description = "Mobil Programlama";
Flutter.CategoryId = 5;
Flutter.Price = 60;

CourseManager courseManager = new CourseManager(new EfCourseDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


Console.WriteLine("Tobeto Course Academy");

//courseManager.Add(csharp);
//courseManager.Add(java);
//courseManager.Add(dotNet);
//courseManager.Add(algoritma);
//courseManager.Add(Flutter);

#region OKEY
//Console.WriteLine("******************");


//foreach (var item in courseManager.GetAll().Data)
//{
//    Console.WriteLine(item.Name);
//}
//Console.WriteLine("******************");
//Console.WriteLine(courseManager.GetAll().Message);

//foreach (var item in courseManager.GetCourseDetail().Data)
//{
//    Console.WriteLine(item.CourseName + "----" + item.CategoryName);
//}
#endregion

//category.Id = 1;

//categoryManager.Delete(category);

//foreach (var course in courseManager.GetAll())
//{
//    Console.WriteLine("Kursun Adı: " + course.Name + " Kursun Fiyatı : " + course.Price);
//}












//bool deger = true;
//while (deger)
//{
//    Course kurs3 = new Course();

//    Console.Write("Kursun İsmini Giriniz : ");
//    kurs3.Name = Console.ReadLine();
//    Console.Write("Kursun Fiyatını Giriniz (En az 10 olabilir.): ");
//    kurs3.Price = decimal.Parse(Console.ReadLine());
//    Console.Write("Kategori giriniz : ");
//    kurs3.CategoryId = int.Parse(Console.ReadLine());
//    Console.Write("Kurs Açıklaması Giriniz : ");
//    kurs3.Description = Console.ReadLine();

//    courseManager.Add(kurs3);


//    foreach (var course in courseManager.GetAll())
//    {
//        Console.WriteLine("Kursun Adı: " + course.Name + " Kursun Fiyatı : " + course.Price);
//    }

//    Console.WriteLine("Çıkmak için x'e basın devam etmek için başka tuşa basın.");
//    if (Console.ReadLine().ToLower() == "x")
//    {
//        break;
//    }
//    else
//    {
//        Console.Clear();
//    }
//}




