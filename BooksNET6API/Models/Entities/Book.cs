﻿namespace BooksNET6API.Models.Entities;

public class Book
{
    public Book()
    {
    }

    [Key]
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string Genre { get; set; }
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string PublisherName { get; set; }
}