// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using TechnortalJune.ConsoleApp;

Console.WriteLine("Hello, World!");
AdoDotNetService ado = new AdoDotNetService();
//ado.Create();
//ado.Update();
ado.Delete();
ado.Read();