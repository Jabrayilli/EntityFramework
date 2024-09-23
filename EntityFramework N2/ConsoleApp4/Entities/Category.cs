﻿namespace ConsoleApp4.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Product { get; set; }
}
