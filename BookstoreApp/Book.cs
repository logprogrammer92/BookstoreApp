using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookstoreApp
{
    /// <summary>
    /// Represents an individual book for sale.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// The primary key/unique identifier for the book.
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// The title of the book.
        /// </summary>
        public required string title { get; set; }

        /// <summary>
        /// Sales price of the book.
        /// </summary>
        public double price { get; set; }
    }
}
