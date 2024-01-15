﻿using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art Of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language"),
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            var b = new Book(1, "gfdg");
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    }
}
