using BESTYBUYPRACTICES;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

var repo = new DapperDepartmentRepository(conn);

var departments = repo.GetAllDepartments();


foreach (var dept in departments)
{
    Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
}

Console.WriteLine("Do you want to add a deparrtment?");

string userResponse = Console.ReadLine();

if (userResponse.ToLower() == "yes")
{
    Console.WriteLine("What is the name of you new Department?");
    userResponse = Console.ReadLine();

    repo.InsertDepartment(userResponse);
}
Console.WriteLine("Thank you have a nice day.");


var repo1 = new DapperProductRepository(conn);
var products = repo1.GetAllProducts();

foreach (var prod in products)
{
    Console.WriteLine($"{prod.CategoryID} {prod.Name}");
}
