using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PollProject.Models
{
    public class Poll
    {
        private string? name;
        private string? surname;
        private string? email;
        private string? phone;
        private string? dateTime;
        private Gender gender;

        // Properties

        public string? Name
        {
            get { return name; }
            set
            {
                if (!Regex.IsMatch(value!, "^[A-Z][a-zA-Z]*$"))
                {
                    throw new Exception("Your name is not valid. Name only can be start with big char!");
                }
                name = value;
            }
        }
        public string? Surname
        {
            get { return surname; }
            set
            {
                if (!Regex.IsMatch(value!, "^[A-Z][a-zA-Z]*$"))
                {
                    throw new Exception("Surname cannot start with ");
                }
                surname = value;
            }
        }
        public string? Email
        {
            get { return email; }
            set
            {
                if (!Regex.IsMatch(value!, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
                {
                    throw new Exception("Invalid email");
                }
                email = value;
            }
        }
        public string? Phone
        {
            get { return phone; }
            set
            {
                if (!Regex.IsMatch(value!, @"^\+99455\d{3}\d{2}\d{2}$ | ^\+99499\d{3}\d{2}\d{2}$ | ^\+99412\d{3}\d{2}\d{2}$ | ^\+99450\d{3}\d{2}\d{2}$ | ^\+99451\d{3}\d{2}\d{2}$ | ^\+99470\d{3}\d{2}\d{2}$ | ^\+99477\d{3}\d{2}\d{2}$ | ^055\d{3}\d{2}\d{2}$ | ^099\d{3}\d{2}\d{2}$ | ^012\d{3}\d{2}\d{2}$ || ^050\d{3}\d{2}\d{2}$ || ^051\d{3}\d{2}\d{2}$ || ^070\d{3}\d{2}\d{2}$ || ^077\d{3}\d{2}\d{2}$"))
                {
                    throw new Exception("Invalid phone number");
                }
                phone = value;
            }
        }
        public string? DateTime { get { return dateTime; } set { dateTime = value; } }
        public Gender Gender { get { return gender; } set { gender = value; } }

        // Constructors

        public Poll() { }
        public Poll(string? name, string? surname, string? email, string? phone, string? datetime, Gender gender)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            DateTime = datetime;
            Gender = gender;
        }

    }
}
