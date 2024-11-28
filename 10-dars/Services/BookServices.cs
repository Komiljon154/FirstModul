using ConsoleApp1.Models;
using System.Collections.Generic;
using System;

namespace _10_dars_CRUD.Services
{

    internal class BookServise
    {
        private List<Book> books;
        public BookServise()
        {
            books = new List<Book>();
        }
        public Book AddBook(Book newbook)
        {
            newbook.Id = Guid.NewGuid();
            books.Add(newbook);
            return newbook;
        }
        public Book GetById(Guid id)
        {
            foreach (var bookDb in books)
            {
                if (bookDb.Id == id)
                {
                    return bookDb;
                }

            }
            return null;
        }
        public bool DeletedBook(Guid id)
        {
            var bookDb = GetById(id);
            if (bookDb == null)
            {
                return false;
            }
            books.Remove(bookDb);
            return true;
        }
        public bool UpdateBook(Book newBook)
        {
            var bookDb = GetById(newBook.Id);
            if (bookDb == null)
            {
                return false;
            }
            var index = books.IndexOf(bookDb);
            books[index] = newBook;
            return true;
        }
        public List<Book> GetAllBook()
        {
            return books;
        }
        public Book GetExpensiveBook()
        {
            var expensiveBook = new Book();

            foreach (var bookDb in books)
            {
                if (expensiveBook.Price < bookDb.Price)
                {
                    expensiveBook = bookDb;
                }
            }
            return expensiveBook;
        }
        public Book GetMostPagedBook()
        {
            var mostpageBook = new Book();
            foreach (var bookDb in books)
            {
                if (mostpageBook.PageNumber < bookDb.PageNumber)
                {
                    mostpageBook = bookDb;
                }
            }
            return mostpageBook;
        }


    }
}