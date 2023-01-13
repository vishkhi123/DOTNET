﻿namespace BOL;
public class Product
{
   public int Id{get;set;}

    public string? Name{get;set;}

    public string? Description{get;set;}

    public double Price{get;set;}

    public string? Image{get;set;}

    public Product()
    {

    }

    public Product( int id,string name,string description,double price,string image)
    {
        
        this.Name=name;
        this.Description=description;
        this.Price=price;
        this.Image=image;
    }

}
