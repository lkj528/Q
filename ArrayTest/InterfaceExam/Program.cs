using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExam
{
    interface IEquatable<T>
    {
        
            .Equals(T obj);

        

    }




    public class Emp : IEquatable<Emp>
    {

        public string name{get;set;};
        public int sabun{get;set;}

        public  bool Equals(Emp e)
        { 
            (채우기)
        }



    }



    public class Car : IEquatable<Car>
    {
        public string Maker {get; set;}
        public string Model {get; set;}
        public string Year {get; set;}



        public bool Equals(Car car)
        {


            

             if(Maker(c1) == car.c1)
             {
                 return true;
             }
             
            
        }
        

    }


    public class CarTest
    {
        static void Main()
        {

            Car c1 = new Car()
            {
                Maker = "현대", Model = "그랜져", Year="2016"
            };

            Car c2 = new Car()
            {
                Maker = "현대", Model = "그랜져", Year="2015"
            };

            if(c1.Equals(c2))
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다");
            }



            Emp e1 = new Emp()
            {
                name = "홍길", sabun = 1004
            };

            Emp e2 = new Emp()
            {
                name = "홍길", sabun= 1004
            };


            if(e1.Equals(e2))
            {
                Console.WriteLine("같다2");
            }
            else
            {
                Console.WriteLine("다르다2");
            }
        }









    }


}
