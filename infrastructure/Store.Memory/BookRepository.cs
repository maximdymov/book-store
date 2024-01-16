﻿using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12345-12345", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 12345-12346", "M. Fowler","Refactoring"),
            new Book(3, "ISBN 12345-12347", "B. Kernighan, D.Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query) 
                                    || book.Title.Contains(query))
                        .ToArray();
        }
    }
}
