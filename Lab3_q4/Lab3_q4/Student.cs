using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_q4
{
    public class Student
    {
        private int rollNumber;
        public int RollNumber
        {
            get { return rollNumber; }
            set
            {
                rollNumber = value;
            }
        }
        private string studentName;
        public string StudentName
        {
            get { return studentName; }
            set
            {
                studentName = value;
            }
        }
        private byte age;
        public byte Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }
        private DateTime dateofbirth;
        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set
            {
                dateofbirth = value;
            }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
        private float percentage;
        public float Percentage
        {
            get { return percentage; }
            set
            {
                percentage = value;
            }
        }
    }
}


