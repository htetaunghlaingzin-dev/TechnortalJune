// See https://aka.ms/new-console-template for more information
using TechnortalJune.DatabaseFirstEFCore.AppDbContextDbFirstModels;
using TechnortalJune.EFCoreModelFirst;

Console.WriteLine("Hello, World!");
//AppDbContextModelFirst db=new AppDbContextModelFirst();
////var lst=db.Staffs.ToList();
////foreach(var item in lst)
////{
////    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
////}
////Read
//StaffEntity?  staff1=db.Staffs.Where(x=>x.Name=="Htet Aung Hlaing Zin").FirstOrDefault();
//StaffEntity? staff2 =db.Staffs.Where(x=>x.Name=="khs").FirstOrDefault();
//Console.WriteLine($"staff: {staff1?.Name}");
//Console.WriteLine($"staff: {staff2?.Name}");
////create
////Console.WriteLine("Creating Staff");
////StaffEntity staffEntity=new StaffEntity()
////{
////    Name = "khs"
////};
////db.Add(staffEntity);
////int result=db.SaveChanges();
////Console.WriteLine($"Rows affected: {result}");
////Console.ReadLine();
////update
//var staff3 = db.Staffs.Where(x=>x.Name=="khs").FirstOrDefault();
//if (staff3 == null)
//{
//    Console.WriteLine("name not found");
//}
//else
//{
//    staff3.Name = "plm";
//    int result = db.SaveChanges();
//    Console.WriteLine($"Update effected {result} rows");
//}
////delete
//var staff4 = db.Staffs.Where(x=>x.Name=="plm").FirstOrDefault();
//if (staff4 == null)
//{
//    Console.WriteLine("name not found");
//}
//else
//{
//    db.Remove(staff4);
//    int result = db.SaveChanges();
//    Console.WriteLine($"Delete effected {result} rows");
//}
AppDbContextDbFirst db1 = new AppDbContextDbFirst();
db1.TblStaffs.ToList();
db1.Students.ToList();
db1.Users.ToList();
//table1
var products=db1.Products.ToList();
foreach(var item in products)
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