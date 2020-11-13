﻿using System;
using System.Text;

namespace school_library
{
    public class School
        {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("Twitter address must begin with '@'");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string schoolName, string schoolPhoneNumber)
        {
            Name = schoolName;
            PhoneNumber = schoolPhoneNumber;
        }

        public static float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
            return sb.ToString();
        }
    }
}
