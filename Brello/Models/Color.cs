using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Color : IComparable
    {
        public int ColorId { get; }
        public string Name { get; set; }
        public string Value { get; set; }

        public int CompareTo(object obj)
        {
            Color other_color = obj as Color;
            //Other way to cast
            //Color other_color = (Color)obj; ***returns null***
            return this.Name.CompareTo(other_color.Name);
            
            //throw new NotImplementedException();
        }
    }
}