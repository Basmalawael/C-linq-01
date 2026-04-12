using C__linq_01.Models;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__linq_01.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //1. Get all products from the "Seafood" category. Print each 
            // product's name and price. 

            // Query Syntax :

            /*
            var result = from p in Source.ProductList
                         where p.Category == "Seafood"
                         select new { p.ProductName,p.Category, p.UnitPrice };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            } 

            // Method Syntax :

            var res = Source.ProductList.Where(p => p.Category == "Seafood")
                                        .Select(p => new { p.ProductName , p.Category , p.UnitPrice });

                    foreach (var item in res)
                 {
                     Console.WriteLine(item);
                 }
            */

            #endregion

            #region 2
             
            // Get a list of only the product names from ProductList. Print each name.

            //Query Syntax :
            /*
            var result = from p in Source .ProductList
                         select (p.ProductName);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //Method Syntax:

            var result1 = Source.ProductList.Select(p => p.ProductName); 


            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            */

            #endregion

            #region 3 
             
            // Sort all products by UnitPrice(ascending).Print each product's name and price. 

            // Query Syntax :
            /*
            var result = from p in Source .ProductList 
                         orderby p.UnitPrice ascending
                         select new {p.ProductName , p.UnitPrice};


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //Method Syntax :

            var result1 = Source.ProductList .OrderBy (p => p.UnitPrice) //ascending 
                                  .Select(p => new {p.ProductName, p.UnitPrice});

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        */
            #endregion

            #region 4
             
            // Get all products where UnitPrice is between 10 and 30
            /*
            var result = from p in Source.ProductList
                         where p.UnitPrice >= 10 && p.UnitPrice <=30
                         select p;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

     

            var res = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
                                         

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
           */

            #endregion

            #region 5

            //5. Get all products that are in stock (UnitsInStock > 0) and
            //belong to the "Condiments" category.

            //Query Syntax :
            /*
            var result = from p in Source.ProductList
                         where p.UnitsInStock > 0 && p.Category == "Condiments"
                         select p;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            //Method Syntax :

            
        var result1 = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            } 
         */

            #endregion

            #region 6 

            //6. Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price StockStatus →
            //a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            //● Print the result.

            //Method Syntax :
            /*
            var res1 = Source.ProductList.Select(p => new
            {
                Name = p.ProductName ,
                Price = p.UnitPrice ,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"

            });


            foreach (var item in res1)
            {
                Console.WriteLine($"ProductName :{item.Name} | Price :{item.Price}  | Status :{item.StockStatus}");
            }
           

            //Query Syntax :
            var res2 = from p in Source.ProductList
                       select new
                       {
                           Name = p.ProductName,
                           Price = p.UnitPrice,
                           StockStatus = p.UnitsInStock > 0 ? "Available" : " Out of Stock"
                       };

            foreach (var item in res2)
            {
                Console.WriteLine($"ProductName :{item.Name} | Price :{item.Price} | Status :{item.StockStatus}");
            }
        */

            #endregion

            #region 7 
            /*
           // Print each product's name along with its position (1-based) 
           // in the list. Expected format: 1. Chai, 2. Chang, etc. 
            
            //Method Syntax :

            var result = Source.ProductList.Select((p, index) => $"{index + 1} . {p.ProductName}");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region 8

            //  * 8. Sort ProductList by Category ascending,
            //  * then within each category, sort by UnitPrice descending. 


            //Method Syntax :
            /*
            var result2 = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
       

            //Query Syntax :

            var res = from p in Source.ProductList
                      orderby p.Category, p.UnitPrice descending
                      select p;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }   
            */


            #endregion

            #region 9


            //. Get all products from the "Beverages" category, sorted by
            // UnitsInStock descending. Print name and stock. 

            //Method Syntax :
            /*
          var result = Source.ProductList.Where(p => p.Category == "Beverages")
                                         .OrderByDescending(p => p.UnitsInStock)
                                         .Select(p => new
                                         {
                                           p.ProductName , p.UnitsInStock
                                         });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

         

            //Query syntax :
            var res = from p in Source.ProductList
                      where p.Category == "Beverages"
                      orderby p.UnitsInStock descending
                      select new {p.ProductName , p.UnitsInStock };

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

   */

            #endregion

            #region 10
            //Using QUERY SYNTAX with a compound from clause, list 
            // all orders placed in 1997 or later showing CustomerID and OrderDate.

            //Query Syntax :
            /*
            var res = from c in Source.CustomerList
                      from o in c.Orders
                      where o.OrderDate.Year >= 1997
                      select new { c.CustomerID, o.OrderDate };

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            */

            #endregion

            #region 11
            //. Show position number alongside ProductName
            /*
            var res = Source.ProductList .Select((p , index ) => $"{index +1 } . {p.ProductName}");

             foreach (var item in res)
             {
                 Console.WriteLine(item);
             }
             */

            #endregion

            #region 12 

            /*
            // Sort first by-word length and then by a 
            //case -insensitive sort of the words in an array.  

   string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry" };

            var res = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);


            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region 13
            /*
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var res = digits.Where(d => d.Length > 1 && d[1] == 'i')
                            .Reverse();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

        }
    }
}
