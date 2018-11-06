using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    class Sale
    {
        public string Name { get; set; }
        public string Goods { get; set; }
    }

    class Onj
    {
        static void Main(string[] args)
        {
            Customer[] customer =
            {
                new Customer() {Name = "ONJSYSTEM", Age = 8},
                new Customer() {Name = "오라클자바커뮤니티실무학원", Age = 6},
                new Customer() {Name = "오라클자바커뮤니티", Age = 13}
            };


            Sale[] sale =
            {
                new Sale() {Name = "ONJSYSTEM", Goods= "볼펜"},
                new Sale() {Name="오라클자바커뮤니티실무학원", Goods = "연필"},

            };




            var result1 = from c in customer
                          join s in sale on c.Name equals s.Name
                          select new
                          {
                              Name = c.Name,
                              Age = c.Age,
                              Goods = s.Goods
                          };

            foreach (var x in result1)
            {
                Console.WriteLine("이름: {0}, 나이: {1}, 상품: {2}", x.Name, x.Age, x.Goods);
            }



            result1 = from c in customer
                      join s in sale on c.Name equals s.Name into tmp
                      from s in tmp.DefaultIfEmpty(new Sale() { Goods = "상품없음" })
                      select new
                      {
                          Name = c.Name,
                          Age = c.Age,
                          Goods = s.Goods
                      };
            Console.WriteLine("--------------------------------------------");
            foreach(var x in result1)
            {
                Console.WriteLine("이름: {0}, 나이: {1}, 상품: {2}", x.Name, x.Age, x.Goods);
            }



        }
    }





}
