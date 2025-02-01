using System;
using System.Collections.Generic;
class Program
{
   public class Scripture
        {
            private Reference _reference;
            private List<Word> _words = new List<Word>();
            
            public Scripture(Reference reference, string text)
            {
                _reference = reference;
            }

            void HideRandomWords(int NumberToHide)
            {
                
            }

            string GetDisplayText()
            {
                return "";
            }

            //bool IsCompletelyHidden()
            //{
            //    return "";
            //}
        }
        
        public class Word
        {
            private string _text;
            private bool _IsHidden;

            public Word(string text)
            {
                _text = text;
            }

            public void Hide()
            {
                
            }

            public void Show()
            {
                
            }

            public bool IsHidden()
            {
                return _IsHidden;
            }

            public string GetDisplayText()
            {
                return "";
            }

        }
        public class Reference
        {
            private string _book;
            private int _chapter;
            private int _verse;
            private int _endVerse;

            Reference(string book, int chapter, int verse)
            {
                _book = "";
                _chapter = chapter;
                _verse = verse;
            }
            Reference(string book, int chapter, int StartVerse, int endVerse)
            {
                _book = book;
                _chapter = chapter;
                _verse = StartVerse;
                _endVerse = endVerse;
            }
            string GetDisplayText()
            {
                return "";
            }
        }
}