using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Collections;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Book[] Booksarray =
        {
            new Book("Author1 ", "Testing1 ", 252, 1997),
            new Book("Author2 ", "Testing2 ", 352, 2007),
            new Book("Author3 ", "Testing3 ", 306, 2003),
            new Book("Author4 ", "Testing4 ", 407, 2022)
        };
        Array.Sort(Booksarray);
        Console.WriteLine("Sorted People by Age:");
        foreach (var Book in Booksarray)
        {
            Console.WriteLine(Book);
        }
    }
}
public class Book : IComparable<Book>
{
    private string author;
    private string title;
    private int pages;
    private int year;

    public Book(string author, string title, int pages, int year)
    {
        this.author = author;
        this.title = title;
        this.pages = pages;
        this.year = year;
    }

    public int CompareTo(Book other)
    {
        return this.year.CompareTo(other.year);
    }
    public override string ToString()
    {
        return $"Author: {author}, Title: {title}, Pages: {pages}, Year:{year}";
    }
}