namespace BOL;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Required]
    public int id{get;set;}

  [Required]
    public string? name{get;set;}

  [Required]
    public string? place{get;set;}
}