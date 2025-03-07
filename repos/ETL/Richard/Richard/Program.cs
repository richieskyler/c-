using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Richard.Models;
using Richard.Services;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string FirstName = "Richard";
            //string SecondName = "OLoyede";
            //int age = 20;
            //Console.WriteLine(value: "Hi Tech Academy");
            //Console.WriteLine(FirstName+ " "+SecondName);
            //Console.WriteLine(Age);
            //const double pi = 3.142D;
            //Console.WriteLine(pi);
            //int myAge = age;
            //myAge = 40;
            //Console.WriteLine(age);
            //Console.WriteLine(myAge);

            //int[] scores = {30, 40, 20};
            //int[] listOfScore = scores;

            //listOfScore[0] = 100;

            //foreach (var item in scores)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in listOfScore)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(value: "Hi, Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);


            //Console.WriteLine("Calculating the Area of a Square");
            //Console.WriteLine("What is the Length");
            //int length  = int.Parse(Console.ReadLine());

            //int area = length * length;
            //Console.WriteLine("The Area of the Square is " + area);

            //int num = 40;
            //object boxed = num;
            //int otherNumber = (int)boxed;

            //string name = "Richard";
            //Console.WriteLine(name.Length);

            //string firstName = "Richard";
            //string lastname = "Oloyede";
            //string fullName = string.Concat(firstName,' ', lastname);
            //Console.WriteLine(fullName);

            //String fname = $"My full name is {firstName} {lastname}";
            //Console.WriteLine(fname);

            //if (20 > 18)
            //{
            //    Console.WriteLine("20 is greater that 18");
            //}

            //int time = 20;
            //string result = (time < 18) ? "Good day" : "Good Evening";
            //Console.WriteLine(result);

            //int i=0;
            //while (i<5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //for (int i = 1; i < 101; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            // -----------------PASSWORD CHECKER------------5 TRIALS, A CHARACTER & A NUMBER -----------------------
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Enter your password: ");
            //    string password = Console.ReadLine();
            //    i++;
            //    PasswordChecker checker = new PasswordChecker();
            //    if (password.Length > 8 && checker.ContainsSpecialCharacter(password))
            //    {
            //        Console.WriteLine("Password Set");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password is Invalid");
            //    }
            //}

            //--------------------------------------------------------------------------------------------------------------

            //------------------------SORT INPUT VALUES SEPARATED BY COMMA--------------------------------------------------
            //Console.WriteLine("Enter a series of Number separated by comma");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //string[] listOfNum = input.Split(',');

            //int[] numbers = listOfNum.Select(num => int.Parse(num.Trim())).ToArray();

            //Console.WriteLine("Sort in Ascending input a or Descending input b");
            //string order = Console.ReadLine();
            //if (order == "a") 
            //{
            //    Array.Sort(numbers);
            //} else if (order == "b")
            //{
            //    Array.Sort(numbers);
            //    Array.Reverse(numbers);
            //} else
            //{
            //    Console.WriteLine("Invalid input for sorting order.");
            //    return;
            //}
            //string output = string.Join(",", numbers);
            //Console.WriteLine("Sorted numbers: " + output);

            //---------------------------------------------------------------------------------------------------------------
            //Person person = new Person("Bolu Emmanul");
            //Calculator calculator = new Calculator(2, 3, '+');
            //calculator.calculate();

            //BankAccount accountBalance = new BankAccount(10000);
            //accountBalance.deposit(1000);

            //Dog dog = new Dog();
            //dog.speak();
            //dog.bark();

            //Shape shape = new Square();
            //Console.WriteLine(shape.calculateArea());

            //Cat cat = new Cat();
            //cat.makeSound();


            //IPerson person = new PersonInterface();

            //person.die();
            //person.eat();
            //person.talk();
            //person.walk();

//----------------------------------------Category Service

            CategoryService categoryService = new CategoryService();

            //--------------------------------------------------------------------------create category

            //Category category = new Category();

            //category.Name = "Clothings";
            //category.Description = "Apparel such as shirts, pants, dresses, and outerwear.";

            //Category? result = categoryService.CreateCategory(category, out string messgae);

            //if (result == null)
            //{
            //    Console.WriteLine(messgae);
            //}
            //else
            //{
            //    Console.WriteLine(messgae + " " + category.Id + " " + category.Name + " " + category.Description);
            //}
            //-----------------------------------------------------------------get category
            //Category result = categoryService.GetCategory(1, out string message);
            //Console.WriteLine(message);
            //Console.WriteLine("Name:" + " " + result.Name + " " + "Description:" + " " + result.Description);

            //---------------------------------------------------------------------get all categories
            //List<Category> result = categoryService.Categories();

            //foreach (var item in result)
            //{
            //    Console.WriteLine("Name:" + " " + item.Name + " " + "Description:" + " " + item.Description);
            //}



            //----------------------------------------------------------Product Service
            //----------------------------------------------------------Create product

            //ProductService productService = new ProductService();

            //Product product = new Product();

            //product.Name = "Blouse";
            //product.Description = "Short Gown";
            //product.Price = 3500;
            //product.Quantity = 1;
            //product.CreatedAt = DateTime.UtcNow;
            //product.CategoryId = 3;

            //Product? result = productService.CreateProduct(product, out string messgae);

            //if (result == null)
            //{
            //    Console.WriteLine(messgae);
            //}
            //else
            //{
            //    Console.WriteLine(messgae + " " + product.id + " " + product.Name + " " + product.Description + " " + product.Price + " " + product.Quantity
            //        );
            //}

            //-----------------------------delete categoryid

            //bool result = categoryService.DeleteCategory(2, out string message);
            //if (result)
            //{
            //    Console.WriteLine(message);
            //}
            //else
            //{
            //    Console.WriteLine(message);
            //}


            //--------------------------------- delete productid 

            //bool result = productService.DeleteProduct(2, out string message);
            //if (result)
            //{
            //    Console.WriteLine(message);
            //}
            //else
            //{
            //    Console.WriteLine(message);
            //}


            //--------------------------------------------------------






















































































        }

}
}
