using ConsoleApp31.Context;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp31
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            VasmoyBazariDb context = new VasmoyBazariDb();
            //IQueryable 
            //Sorguya qarwiliq gelir
            //Ef core uzerinden gonderilen sorgunun execute edilmemiw halidir

            //IEnumurable
            //Sorgularin execute edilib in memorye yuklenmiw halidir

            //Data elde etmeyin 
            //Method syntax
            //var products = await context.Products.ToListAsync();

            //Query syntax
            //var products = from product in context.Products
            //                select product;


            //Deferred Execution - gozlenilen sorgu

            //int productId = 8;

            //var products = from product in context.Products
            //               where product.Id > productId
            //               select product;

            //productId = 20;


            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.Id.ToString() +"."+ product.ProductName);
            //}





            //Where
            //Method syntax
            //var product = await context.Products.Where(p => p.Id > 20).ToListAsync();

            //product.ForEach(p => { Console.WriteLine(p.Id.ToString() + "." + p.ProductName); });

            //Query syntax
            //var products = from product in context.Products
            //               where product.Id > productId
            //               select product;


            //Order By

            //Method syntax

            //        (await context.Products.OrderBy(p => p.Price).ToListAsync())
            //.ForEach(p => { Console.WriteLine(p.Id.ToString() + "." + p.ProductName); });


            //var products = await context.Products.OrderBy(p => p.Price).ToListAsync();

            //products.ForEach(p => { Console.WriteLine(p.Id.ToString() + "." + p.ProductName+"-"+p.Price.ToString()); });


            //Query syntax

            //var products = await (from product in context.Products
            //                      orderby product.Price
            //                      select product).ToListAsync();

            //products.ForEach(p => { Console.WriteLine(p.Id.ToString() + "." + p.ProductName + "-" + p.Price.ToString()); });


            //Order By Descending 
            //Method syntax

            //var products = await context.Products.OrderByDescending(p=>p.Price).ToListAsync();
            //products.ForEach(p => { Console.WriteLine(p.Id.ToString() + "." + p.ProductName + "-" + p.Price.ToString()); });


            //Query syntax
            //var products = await (from product in context.Products
            //               orderby product.Price descending
            //               select product).ToListAsync();

            //products.ForEach(p => { Console.WriteLine(p.Id.ToString() + "." + p.ProductName + "-" + p.Price.ToString()); });


            //yalniz istediyimiz columnlari ceke bilerik ve diger columnlar gelmir
            //var products = await (from product in context.Products
            //                      orderby product.Price
            //                      select new
            //                      {
            //                          product.ProductName
            //                      }).ToListAsync();



            //Category 
            //Id categoryName

            //Product
            //Id  name  price  CategoryId

            //1.GetAll PRoduct
            //2.GetbyId Product
            //3.Insert Product
            //4.Delete
            //5.Update


        }
    }
}
