using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBooks
{
    public class Book
    {
        protected string name;
        protected string author;
        protected string publishing;
        public string Name {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }
        public string Publishing
        {
            get
            {
                return publishing;
            }

            set
            {
                publishing = value;
            }
        }
        public Book(string name1, string author1, string publishing1)//конструктор книги
        {
            name = name1;
            author = author1;
            publishing = publishing1;
        }
    }
    public delegate int DelegateTask2(Book book1, Book book2);
    public class BooksContainer
    {
        protected List<Book> Books;
        public BooksContainer()//конструктор контейнера книг
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)//додавання книги в контейнер книг
        {
            Books.Add(book);
        }
        public void AddBook(string name, string author, string publishing)//додавання книги в контейнер книг за параметрами
        {
            Book book = new Book(name, author, publishing);
            Books.Add(book);
        }
        public Book this[int index]// індексація
        {
            get
            {
                return Books[index];
            }
            set
            {
                Books[index] = value;
            }
        }
        public static void BooksSort(BooksContainer books, int kBooks, DelegateTask2 del, int p)//сортування книг
        {
            int c = 1;
            while (c==1)
            {
                c = 0;
                for(int i = 0; i < kBooks-1; i++)
                {
                    int l = del(books[i], books[i + 1]);
                    if (l == p)//p - вказує на те, чи сортування буде в порядку алфавіта,чи проти нього
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
                    return -1;
                }
                else if (book1.Name[i] > book2.Name[i])
                {
                    return 1;
                }
            }
            if (k == book1.Name.Length && k != book2.Name.Length)
            {
                return -1;
            }
            else if(k == book1.Name.Length && k == book2.Name.Length)
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
                    return -1;
                }
                else if (book1.Author[i] > book2.Author[i])
                {
                    return 1;
                }
            }
            if (k == book1.Author.Length&& k != book2.Author.Length)
            {
                return -1;
            }
            else if(k == book1.Author.Length && k == book2.Author.Length)
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
                    return -1;
                }
                else if (book1.Publishing[i] > book2.Publishing[i])
                {
                    return 1;
                }
            }
            if (k == book1.Publishing.Length && k != book2.Publishing.Length)
            {
                return -1;
            }
            else if(k == book1.Publishing.Length && k == book2.Publishing.Length)
            {
                return 1;
            }else
            {
                return 0;
            }
        }//порівнюємо імена видавництв  за алфавітом
    }
}
