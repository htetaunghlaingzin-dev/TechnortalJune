// See https://aka.ms/new-console-template for more information
using TechnortalJune.ConsoleDapperApp;

Console.WriteLine("--Log In--");
Console.Write("Enter your username: ");
string username = Console.ReadLine();
Console.Write("Enter your password: ");
string password = Console.ReadLine();
LoginService loginService = new LoginService();
loginService.Login(username, password);
//DapperService dp = new DapperService();
////dp.Create();
////dp.Update();
//dp.Delete();
//dp.Read();
