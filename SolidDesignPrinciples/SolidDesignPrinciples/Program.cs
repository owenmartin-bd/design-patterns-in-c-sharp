// See https://aka.ms/new-console-template for more information
using SolidDesignPrinciples.OpenClosedPrinciple;
using SolidDesignPrinciples.OpenClosedPrinciple.Filters;
using SolidDesignPrinciples.SingleResponsibilityPrinciple;
using SolidDesignPrinciples.LiskovSubstitutionPrinciple;
using System.Diagnostics;

using static System.Console;


#region Single Responsibility Principle

//var j = new Journal();
//j.AddEntry("I cried today.");
//j.AddEntry("I ate a bug.");
//Console.WriteLine(j);

//var p = new Persistance();
//var filename = @"e:\Temp\journal.txt";
//p.SaveToFile(j, filename, true);
//Process.Start(filename);

#endregion

#region Open/Closed Principle

//var apple = new Product("Apple", Color.Green, Size.Small);
//var tree = new Product("Tree", Color.Green, Size.Large);
//var house = new Product("House", Color.Blue, Size.Large);

//Product[] products = [apple, tree, house];
//var pf = new ProductFilter();
//WriteLine("Green products (old):");
//foreach (var p in pf.FilterByColor(products, Color.Green))
//{
//    WriteLine($" - {p.Name} is green");
//}

//var bf = new BetterFilter();
//WriteLine("Green products (new):");
//foreach (var p in bf.Filter(products, new ColorSpecfication(Color.Green)))
//{
//    WriteLine($" - {p.Name} is green");
//}

//WriteLine("Large blue items");
//foreach (var p in bf.Filter(
//    products, new AndSpecification<Product>(
//        new ColorSpecfication(Color.Blue),
//        new SizeSpecfication(Size.Large))))
//{
//    WriteLine($" - {p.Name} is large and blue");
//}

#endregion

#region Liskov Substitution Principle

/*Rectangle rc = new(2, 3);
WriteLine($"{rc} has area {Area(rc)}");

Rectangle sq = new Square()
{
    Width = 4
};
WriteLine($"{sq} has area {Area(sq)}");

static int Area(Rectangle r) => r.Width * r.Height;*/

#endregion

