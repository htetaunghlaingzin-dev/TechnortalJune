// See https://aka.ms/new-console-template for more information
using TechnortalJune.DatabaseFirstEFCore.AppDbContextDbFirstModels;

Console.WriteLine("Hello, World!");
AppDbContextDbFirst db1 = new AppDbContextDbFirst();
db1.TblStaffs.ToList();
db1.Students.ToList();
db1.Users.ToList();
//table1
var products = db1.Products.ToList();
foreach (var item in products)
{
    Console.WriteLine($"Product: {item.ProductName}");
}
//table2
//var book = db1.Books.ToList();
//foreach (var item in book)
//{
//    Console.WriteLine($"Book: {item.Title}");
//}
//table3
var department = db1.Departments.ToList();
foreach (var item in department)
{
    Console.WriteLine($"Department: {item.DepartmentName}");
}
//scffold swll tae time mhr succeed dok phit nay thyy dl but d htll mhr dok error phit nay dl cmt m pake yin
//and class library htll mhr dok ak delete like tae table yae class ka kyn nay khae dl