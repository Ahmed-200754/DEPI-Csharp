using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EFDay03.Models

//Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
//because of the convention in Entity Framework Core. By default, EF Core treats a property named "Id" or "<ClassName>Id" as the primary key for the entity. In this case, since the class is named "Book" and it has a property named "Id", EF Core automatically recognizes it as the primary key without needing any explicit configuration.
//Q2: Why is "Country" nullable in the database while "Price" is not?
//The "Country" property is nullable in the database because it is defined as a string which is nullable in the C# class. In contrast, the "Price" property is defined as a non-nullable decimal in the C# class, which means it cannot be null.

{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? PublishedDate { get; set; }
        public decimal Price { get; set; }
    }
}
