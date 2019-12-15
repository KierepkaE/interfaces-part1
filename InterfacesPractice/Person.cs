﻿using System;
namespace InterfacesPractice
{
    public class Person
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }
        public string FormatString { get; set; }

        public override string ToString() {
            FormatString = "{0} {1}";
            return string.Format(FormatString, GivenName, FamilyName);

        }
    }
}
