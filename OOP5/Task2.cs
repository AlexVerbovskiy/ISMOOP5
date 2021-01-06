using System;
using System.Text;
using ClassBooks;
namespace OOP5
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість книг:");
            int kBooks= int.Parse(Console.ReadLine());
            BooksContainer books = new BooksContainer();
            for (int i = 0; i < kBooks; i++)
            {
                Console.WriteLine("Назва книги:");
                string name= Console.ReadLine();
                Console.WriteLine("Автор:");
                string author = Console.ReadLine();
                Console.WriteLine("Видання:");
                string publishing = Console.ReadLine();
                books.AddBook(name, author, publishing);
            }
            DelegateTask2 del= new DelegateTask2(DopClass.FuncName);
            Console.WriteLine("Введіть номер критерія по якому хочете відсортувати книги в алфавітному порядку(1-3):");
            int numDel = int.Parse(Console.ReadLine());
            if (numDel == 2)
            {
                del = DopClass.FuncAuthor;
            }else if(numDel==3)
            {
                del = DopClass.FuncPublishing;
            }else if (numDel != 1)
            {
                Console.WriteLine("Ви ввели неправильне значення");
            }
            Console.WriteLine("Введіть 1, якщо хочете, щоб книги були посортовані за алфавітом, введіть -1, якщо хочете, щоб книги були посортовані в зворотньому порядку за алфавітом:");
            int p = int.Parse(Console.ReadLine());
            BooksContainer.BooksSort(books, kBooks, del,p);
            for(int i = 0; i < kBooks; i++)
            {
                Console.WriteLine($"{books[i].Name} {books[i].Author} {books[i].Publishing}");
            }
        }
    }

}
