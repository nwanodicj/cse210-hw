using System;
using System.Collections.Generic;
public class Video
{
    public string _Title;
    public string _Author;
    public double _Lenght;

    public Video()
    {
        
    }
    public Video(string title, string author, double lenght)
    {
        _Title = title;
        _Author = author;
        _Lenght = lenght;
       
    }

    public double GetLenght()
    {
        return _Lenght;
    }

    public string GetString()
    {
        if (_Lenght == 1)
        {
            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: This movie is marvelous.");
            Console.WriteLine("UserName: Chuks");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");

            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: Wow this is good.");
            Console.WriteLine("UserName: light");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");

            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: I love this movie.");
            Console.WriteLine("UserName: loveth");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");
        }

        if (_Lenght == 2)
        {
            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: I was afraid.");
            Console.WriteLine("UserName: True");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");     
            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: The Bose is too Evil.");
            Console.WriteLine("UserName: Even");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");
       }


        if (_Lenght == 3)
        {
            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: I was not afraid.");
            Console.WriteLine("UserName: Faith");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");      
            Console.WriteLine($"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}");
            Console.WriteLine("Comment: The actor was very smart but the bose was too Evil.");
            Console.WriteLine("UserName: Angel");
            Console.WriteLine($"PostedDateTime: {DateTime.Now}");
            Console.WriteLine("");
        }
        return $"Title: {_Title}, \nAuthor: {_Author}, \nViews: {_Lenght}";
    }
    public void Play()
    {
        GetString();
    }
}
