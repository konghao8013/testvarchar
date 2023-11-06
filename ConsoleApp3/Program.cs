// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Models;

while (true)
{
    using (var db = new AAAContext())
    {
        var item = db.TestVarchar.FirstOrDefault();
        item.Tvalue = item.Tvalue + "<你.*";
        db.SaveChanges();
    }
}
Console.WriteLine("Hello, World!");
