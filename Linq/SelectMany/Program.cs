using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{


    class Customer
    {
        public string Name { get; set; }
        public List<String> Cards { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals  =  { "cat", "dog", "donkey" };
            int[] number = { 10, 20 };


            var mix = number.SelectMany(num => animals, (n, a) => new { n, a });

            foreach (var a in mix)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------------------------");

            Customer[] customers =
            {
                new Customer {Name = "김길이", Cards = new List<string>{"BC","VISA"} },
                new Customer {Name = "나길이", Cards = new List<string>{"HANA","KB"} },
                new Customer {Name = "홍길이", Cards = new List<string>{"SHINHAN","BC"} }


                
            };
            IEnumerable<string> query1 = customers.SelectMany(c => c.Cards);
            foreach(string card in query1)
            {
                Console.WriteLine(card);


                var mix2 = animals.SelectMany(n => n).ToList();
                mix2.ForEach(n => Console.WriteLine(n));

            }
        }
    }
}
