// See https://aka.ms/new-console-template for more information

using System;
using ConsoleApp3;


class Program
{
     static void Main()
    {
        Variables v1 = new Variables();
        v1.LuckyNumber();

        Circle a1 = new Circle();
        a1.Area();
        
        
        DataType d1  = new DataType();
        d1.DataTypeChecker();
        
        
        Arrays arr1 = new Arrays();
        arr1.ArryasMethod();
        
        DateTimeExample  date1 = new DateTimeExample();
        date1.DateTimeChecker();
        
        Generic generic1 = new Generic();
        generic1.GenericMethod();
    }
     
}


    
