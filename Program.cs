



using System.IO;



int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15, 16 };

var evenNumber = from n in numbers
                 where n%2==0
                 orderby n 
                 select n;

Console.WriteLine(" Task 1");

foreach (var n in evenNumber)
{
    Console.Write($"{n} ");
}

//--------------------------------------------------------

string[] sounds = { "Му", "Кукареку", "Мяу", "Гав", "Ква", "Аррр", "Фрр" };
var longS = from s in sounds
            where s.Length > 3
            orderby s
            select s;

Console.WriteLine("\n\n Task 2");
foreach (var s in longS)
{
    Console.Write($"{s} ");
}
//--------------------------------------------------------

var peoples = new List<Person>()
{
    new Person("Fred", 12),
    new Person("Jhon", 21),
    new Person("Bred", 19),
    new Person("Carl", 15),
    new Person("Jeff", 24)
};

var adult = from p in peoples
            where p.age >=18
            orderby p.age
            select p;
            
Console.WriteLine("\n\n Task 3");

foreach (var a in adult)
{
    Console.WriteLine($"{a.name + " " + a.age + " y.o."} ");
}

//--------------------------------------------------------


int[] nums = {0,5,10,15,20,25,30,35,40,45,50,55,60};


var more10less50 = from n in nums
                   where n>10 && n<50
                   orderby n
                   select n;

Console.WriteLine("\n Task 4");
foreach (var m in more10less50)
{
    Console.Write($"{m} ");
}
//--------------------------------------------------------


string[] brands = { "adidas", "Abercrombie & Fitch", "Dolce&Gabana", "armani exchange",
    "YSL", "Brunello Cucinelli", "Stefano Ricci", "Santony", "Acne" };

var brandA = from b in brands
             where b.ToUpper().StartsWith("A")
             orderby b
             select b.ToUpper();


Console.WriteLine("\n\n Task 5");
foreach (var b in brandA)
{
    Console.WriteLine($"{b} ");
}
//--------------------------------------------------------
var goods = new List<Order>
{
    new Order("Молоко 1л",60),
    new Order("Зефир 1кг",350),
    new Order("Помидор 1кг",80),
    new Order("Свинина 1кг",220),
    new Order("Курица 1кг",120),
    new Order("Базилик 100г",50)
};
var priceOver100 = from g in goods
                   where g.price > 100
                   orderby g.price
                   select g;
Console.WriteLine("\n Task 6");
foreach (var p in priceOver100)
{
    Console.WriteLine($"{p.name + " " + p.price}");
}
//--------------------------------------------------------

double[] numberList = { 1, 2, 3, 4, 5.2, 5.3, 10.2, 4.8,5,6,7,8,9,10,11,12,13,14,15};
var prime = from n in numberList
            where n % 1 == 0 && IsPrime((int)n)
            orderby n
            select n ;
Console.WriteLine("\n Task7");
foreach (var p in prime)
{
    Console.Write($"{p} ");
}

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0) return false;
    }
    return true;
}
//--------------------------------------------------------


record class Person(string name, int age);
record class Order (string name, double price);







