using System;
using System.Collections.Generic;
using System.Text;

namespace H5
{
    class Builder:IDeveloper
    {
        string tool;
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public string Tool
        {
            get { return tool; }
        }
        public void Create()
        {
            Console.WriteLine($"Builder's tool is{tool}");
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
