using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMulti
{
    class MyMap<T, V>
    {
        private T t;
        private V v;



        public void SetTValue(T value)
        {
            t = value;

        }

        public T GetTValue()
        {
            return t;
        }


        public void SetVValue(V value)
        {
            v = value;
        }


        public V GetVValue()
        {
            return v;
        }

        public void Show(T tValue, V vValue)
        {
            Console.WriteLine("First: {0}\nSecond: {1}", tValue, vValue);

        }
}
    class program
    {
        static int Main()
        {
            MyMap<string, int> m1 = new MyMap<string, int>();
            m1.SetTValue("AGE");
            m1.SetVValue(22);
            m1.Show(m1.GetTValue(), m1.GetVValue());

            MyMap<string, string> m2 = new MyMap<string, string>();
            m2.SetTValue("이름");
            m2.SetVValue("홍길동");
            m2.Show(m2.GetTValue(), m2.GetVValue());


            MyMap<int, int> m3 = new MyMap<int, int>();
            m3.SetTValue(100);
            m3.SetVValue(1000);
            m3.Show(m3.GetTValue(), m3.GetVValue());

            return 1; // 채우지 않은 리턴 값을 채워야 컴파일 됨.
        }
    }









}
