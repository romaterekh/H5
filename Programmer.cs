using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    class Programmer:IDeveloper
    {
         string language;
        public Programmer(string language)
        {
            this.language = language;
        }
        
        string tool;
        public string Tool
        {
            get { return tool; }
 
        }
        public void Create()
        {
            Console.WriteLine($"Programmer's language is{language}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Destroying..");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
    }

