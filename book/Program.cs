using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {



            Array<Book> library = new Array<Book>();
            library.Add(new Book("Лучшее в нас", "Стивен Пинкер", "Альпина Нон Фикшен"));
            library.Add(new Book("Биология добра и зла", "Роберт Сапольски", "Альпина Нон Фикшен"));
            library.Sort(Array<Book>.byName);

            Console.ReadKey();
        }
    }
}
