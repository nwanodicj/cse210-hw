using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        List<string> ListOfVideos = new List<string>();
        List<string> ListOfComment = new List<string>();


        Video Video1 = new Video();

        Console.WriteLine("_The Shaolin Master_");
        Console.WriteLine("Statistics");

        Video1._Title = "The Shaolin Master";
        Video1._Author = "MarveRick";
        Video1._Lenght = 1;

        Comment Comment1 = new Comment();
        Comment1._UserName = "Johnson A.";
        Comment1._Text = "This is the best Shaolin movie of the year";
        Comment1._PostedDate = DateTime.Now;

        List<double> TotalViews = new List<double>();
        List<string> TotalComment = new List<string>();
        TotalComment.Add(Comment1._Text);
        TotalViews.Add(Video1._Lenght);
        Console.WriteLine($"Total Views: {TotalViews.Count + 3}");
        Console.WriteLine($"Total Comments: {TotalComment.Count + 3}");
        Console.WriteLine("");
        
        
        
        //Console.WriteLine("_The Monster_");
        //Console.WriteLine("Statistics");
//
        Video Video2 = new Video();
        Video2._Title = "The Monster";
        Video2._Author = "Williams";
        Video2._Lenght = 0;

        Comment Comment2 = new Comment();
        Comment2._UserName = "Reals.";
        Comment2._Text = "So Deadly";
        Comment2._PostedDate = DateTime.Now;

        List<double> TotalViews2 = new List<double>();
        List<string> TotalComment2 = new List<string>();
        TotalComment2.Add(Comment2._Text);
        TotalViews2.Add(Video2._Lenght);
        //Console.WriteLine($"Total Views: {TotalViews2.Count + 2}");
        //Console.WriteLine($"Total Comments: {TotalComment2.Count + 2}");
        Console.WriteLine("");

        
        
        //Console.WriteLine("_The Holy One_");
        //Console.WriteLine("Statistics");
 
        Video Video3 = new Video();
        Video3._Title = "The Holy One";
        Video3._Author = "Bleez";
        Video3._Lenght = 0;

        Comment Comment3 = new Comment();
        Comment3._UserName = "Rav.";
        Comment3._Text = "Oh my goodness! I can not believe this movies, so interesting.";
        Comment3._PostedDate = DateTime.Now;

         List<double> TotalViews3 = new List<double>();
        List<string> TotalComment3 = new List<string>();
        TotalComment3.Add(Comment3._Text);
        TotalViews3.Add(Video3._Lenght);
        //Console.WriteLine($"Total Views: {TotalViews3.Count + 2}");
        //Console.WriteLine($"Total Comments: {TotalComment3.Count + 2}");
        Console.WriteLine("");




        Video Video4 = new Video();
        Video4._Title = "The gods";
        Video4._Author = "Charles";
        Video4._Lenght = 0;

        Comment Comment4 = new Comment();
        Comment4._UserName = "James";
        Comment4._Text = "So interesting";
        Comment4._PostedDate = DateTime.Now;

        
        ListOfVideos.Add(Video1._Title);
        ListOfVideos.Add(Video2._Title);
        ListOfVideos.Add(Video3._Title);
        ListOfVideos.Add(Video4._Title);

        ListOfComment.Add(Comment1._Text);
        ListOfComment.Add(Comment2._Text);
        ListOfComment.Add(Comment3._Text);
        ListOfComment.Add(Comment4._Text);


        //ListOfVideos.Add(Comment1._UserName);
        //ListOfVideos.Add(Comment1._Text);
        
        string DisplayVideo1 = $"{Video1.GetString()}, \n{Comment1.ToString()}";
        string DisplayVideo2 = $"{Video2.GetString()}, \n{Comment2.ToString()}";
        string DisplayVideo3 = $"{Video3.GetString()}, \n{Comment3.ToString()}";
        string DisplayVideo4 = $"{Video4.GetString()}, \n{Comment4.ToString()}";

        Console.WriteLine(DisplayVideo1);
        Console.WriteLine("");
        Console.WriteLine(DisplayVideo2);
        Console.WriteLine("");
        Console.WriteLine(DisplayVideo3);
        Console.WriteLine("");
        Console.WriteLine(DisplayVideo4);
        Console.WriteLine("");


        Console.WriteLine($"Number of Videos: {ListOfVideos.Count}");
        Console.WriteLine($"Number of Comments: {ListOfComment.Count}");
        Console.WriteLine("");
    }
}