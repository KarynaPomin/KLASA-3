using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DziedziczenieKompozycjaBiblioteka
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Author : Person     
    {
        public List<Book> BookList { get; set; }
        public Author(string firstName, string lastName) : base(firstName, lastName)
        {
            BookList = new List<Book>();
        }

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }
    }

    public class Reader : Person
    {
        public List<Book> BorrowedBooksList { get; set; }

        public Reader(string firstName, string lastName) : base(firstName, lastName)
        {
            BorrowedBooksList = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooksList.Add(book);
            Console.WriteLine($"Czytelnik {FirstName} {LastName} wypożyczył książkę {book}");
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, Author author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }

    public class Library
    {
        public List<Book> BooksList { get; set; } 
        public List<Reader> ReadersList { get; set; }

        public Library()
        {
            BooksList = new List<Book>();
            ReadersList = new List<Reader>();
        }

        public void AddBook(Book book)
        {
            BooksList.Add(book);
        }

        public void AddReader(Reader reader)
        {
            ReadersList.Add(reader);
        }

        public void BorrowBook(Reader reader, Book book)
        {
            reader.BorrowBook(book);
;        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library libraryMain = new Library();
            Console.WriteLine("Witamy w naszej bibliotece!");

            ShowMenu(libraryMain);

            Console.ReadKey();
        }
        public static void ShowMenu(Library library)
        {
            while(true)
            {
                Console.WriteLine("1. Dodaj książkę do katalogu.");
                Console.WriteLine("2. Dodaj nowego czytelnika.");
                Console.WriteLine("3. Wypożycz książkę.");
                Console.WriteLine("4. Sprawdź wypożyczone książki czytelnika.");
                Console.WriteLine("5. Zamknij program.");

                Console.Write("Wybierz opcję: ");
                int choice;
                bool ifNumberMenu = false;
                do
                {
                    string n = Console.ReadLine();

                    if (!int.TryParse(n, out choice))
                        ErrorColor("Błąd! Podaj liczbę od 1 do 7: ");
                    else if (choice > 7 || choice <= 0)
                         ErrorColor("Błąd! Podaj liczbę od 1 do 7: ");
                    else
                         ifNumberMenu = true;
                } while (ifNumberMenu == false);

                switch (choice)
                {
                    case 1:
                        string authorName = GetValueString("Imię autora: ");
                        string authorSurname = GetValueString("Nazwisko autora: ");
                        Author author = new Author(authorName, authorSurname);

                        Console.Write("Tytuł książki: ");
                        string bookTitle = Console.ReadLine();

                        int bookPublicationYear = GetValueYear("Rok publikowania książki: ");

                        Book book = new Book(bookTitle, author, bookPublicationYear);
                        library.AddBook(book);
                        SuccessColor("Książka została dodana!");

                        break;
                    case 2:
                        string readerName = GetValueString("Imię czytelnika: ");
                        string readerSurname = GetValueString("Nazwisko czytelnika: ");
                        Reader reader = new Reader(readerName, readerSurname);

                        library.AddReader(reader);
                        SuccessColor("Nowy czytelnik został dodany!");
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Zamykam aplikację...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }

        public static int GetValueYear(string text)
        {
            bool isTrue = false;
            int year;

            do
            {
                Console.Write(text);
                string y = Console.ReadLine();
                if (!int.TryParse(y, out year))
                    ErrorColor("Błąd! Podaj poprawnie rok.");
                else if (year > DateTime.Now.Year || year <= 0)
                    ErrorColor("Błąd! Podaj poprawnie rok.");
                else
                    isTrue = true;
            } while (!isTrue);

            return year;
        }

        public static int GetValueInt(string text)
        {
            bool isTrue = false;
            int value;

            do
            {
                Console.Write(text);
                string n = Console.ReadLine();
                if (!int.TryParse(n, out value) || value > 0)
                    ErrorColor("Błąd! Podaj poprawnie liczbę naturalną.");
                else
                    isTrue = true;
            } while (!isTrue);

            return value;
        }

        public static string GetValueString(string text)
        {
            bool isTrue = false;
            string value;

            do
            {
                Console.Write(text);
                value = Console.ReadLine();
                if (value.Any(char.IsDigit))
                    ErrorColor("Błąd! Podaj nazwę bez znaków i cyfr.");
                else
                    isTrue = true;
            } while (!isTrue);

            return value;
        }

        public static void ErrorColor(string ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex);
            Console.ResetColor();
        }

        public static void SuccessColor(string ex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ex);
            Console.ResetColor();
        }
    }
}

/*

Temat zadania: System Zarządzania Biblioteką
Opis zadania:
Stwórz aplikację konsolową w języku C#, która będzie symulować system zarządzania biblioteką. Aplikacja powinna umożliwiać zarządzanie książkami, autorami oraz wypożyczeniami. W projekcie należy wykorzystać dziedziczenie, konstruktory oraz kompozycję.
Wymagania funkcjonalne:
1.	Klasa Person:
o	Pola: FirstName, LastName.
o	Konstruktor: inicjalizujący pola FirstName i LastName.
2.	Klasa Author (dziedziczy po klasie Person):
o	Pola: BooksList (lista książek napisanych przez autora).
o	Konstruktor: inicjalizujący pola FirstName, LastName oraz pustą listę książek.
o	Metoda: AddBook(Book book) - dodaje książkę do listy książek autora.
3.	Klasa Book:
o	Pola: Title, Author (obiekt klasy Author), PublicationYear.
o	Konstruktor: inicjalizujący pola Title, Author, PublicationYear.
4.	Klasa Reader (dziedziczy po klasie Person):
o	Pola: BorrowedBooksList (lista wypożyczonych książek).
o	Konstruktor: inicjalizujący pola FirstName, LastName oraz pustą listę wypożyczeń.
o	Metoda: BorrowBook(Book book) - dodaje książkę do listy wypożyczeń.
5.	Klasa Library:
o	Pola: BooksList (lista wszystkich książek w bibliotece), ReadersList (lista czytelników).
o	Konstruktor: inicjalizujący pustą listę książek i czytelników.
o	Metody:
	AddBook(Book book) - dodaje książkę do listy książek.
	AddReader(Reader reader) - dodaje czytelnika do listy czytelników.
	BorrowBook(Reader reader, Book book) - umożliwia wypożyczenie książki przez czytelnika.

*/
