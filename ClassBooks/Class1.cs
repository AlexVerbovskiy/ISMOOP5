using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassBooks
{
    public class Book
    {
        public string Name { set; get; }
        public string Author { set; get; }
        public string Publishing { set; get; }
        public Book(string name, string author, string publishing)
        {
            Name = name;
            Author = author;
            Publishing = publishing;
        }
    }
    public delegate int DelegateTask2(Book book1, Book book2);
    public class Books
    {
        public static void BooksSort(Book[] books, int kBooks, DelegateTask2 del)
        {
            int c = 1;
            while (c==1)
            {
                c = 0;
                for(int i = 0; i < kBooks-1; i++)
                {
                    int l = del(books[i], books[i + 1]);
                    if (l == 1)
                    {
                        c = 1;
                        Book bookDop = books[i];
                        books[i] = books[i + 1];
                        books[i + 1] = bookDop;
                    }
                }
            }
        }
    }
    public class DopClass
    {
        public static int FuncName(Book book1, Book book2)
        {
            int k = Math.Min(book1.Name.Length, book2.Name.Length);
            for (int i = 0; i < k; i++)
            {
                if (book1.Name[i] < book2.Name[i])
                {
                    return 0;
                }
                else if (book1.Name[i] > book2.Name[i])
                {
                    return 1;
                }
            }
            if (k == book1.Name.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }//порівнюємо дві назви книги за алфавітом
        public static int FuncAuthor(Book book1, Book book2)
        {
            int k = Math.Min(book1.Author.Length, book2.Author.Length);
            for (int i = 0; i < k; i++)
            {
                if (book1.Author[i] < book2.Author[i])
                {
                    return 0;
                }
                else if (book1.Author[i] > book2.Author[i])
                {
                    return 1;
                }
            }
            if (k == book1.Author.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }//порівнюємо імена авторів за алфавітом
        public static int FuncPublishing(Book book1, Book book2)
        {
            int k = Math.Min(book1.Publishing.Length, book2.Publishing.Length);
            for (int i = 0; i < k; i++)
            {
                if (book1.Publishing[i] < book2.Publishing[i])
                {
                    return 0;
                }
                else if (book1.Publishing[i] > book2.Publishing[i])
                {
                    return 1;
                }
            }
            if (k == book1.Publishing.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }//порівнюємо імена видавництв  за алфавітом
    }
}
