using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkk // Dziedziczenie_Kompozycja_Biblioteka
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName {  get; set; }
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
        public List<Book> BorroweBooksList { get; set; }

        public Reader(string firstName, string lastName) : base(firstName, lastName)
        {
            BorroweBooksList = new List<Book>();
        }

        public void AddBook(Book book)
        {
            BorroweBooksList.Add(book);
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
        public List<Book> LibraryBooksList { get; set; }
        public List<Reader> LibraryReadersList { get; set; }

        public Library()
        {
            LibraryBooksList = new List<Book>();
            LibraryReadersList = new List<Reader>();
        }

        public void AddBook(Book book)
        {
            LibraryBooksList.Add(book);
        }

        public void AddReaders(Reader reader)
        {
            LibraryReadersList.Add(reader);
        }

        public void BorrowBook(Reader reader, Book book)
        {
            // wypożyczenie książki przez czytelnika
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Adam", "Mickiewicz");
            Book book = new Book("Pan Tadeusz", author, 1834);
            Console.ReadKey();
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
