using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface31
{
    internal class Program
    {

        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose() 호출");
            }
        }

        class product : IComparable<product>
        {
           public string Name { get;  set; }
           public int Price { get;  set; }

            public int CompareTo(product other)
            {
               //return this.Price - other.Price;
               //return this.Price.CompareTo(other.Price);
               return this.Name.CompareTo(other.Name);
            }

            public override string ToString()
            {
                //return Name + " : " + Price + "원";
                return $"{Name} : {Price}원";
            }
        }
        static void Main(string[] args)
        {
            List<product> products = new List<product>()
            {
                new product() { Name = "고구마", Price = 1000 },
                new product() { Name = "감자", Price = 2000 },
                new product() { Name = "옥수수", Price = 3000 },
                new product() { Name = "수박", Price = 4000 },
                new product() { Name = "참외", Price = 5000 },
            };

            //정렬
            products.Sort();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            using (Dummy dummy = new Dummy())
            {
                Console.WriteLine("using 블록 실행됨");
            }
            Console.WriteLine("using 블록 벗어남");
        }
    }
}
