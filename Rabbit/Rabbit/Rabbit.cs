using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitHomework
{
    public enum EyesColour
    {
        Blue,
        Red,
        Black
    }

    public enum FurColour
    {
        White,
        Brown,
        Black,
        Grey
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class Rabbit
    {
        EyesColour eyes;
        FurColour fur;
        Gender gender;


        public EyesColour Eyes
        {
            get { return this.eyes; }
            set { this.eyes = value; }
        }

        public FurColour Fur
        {
            get { return this.fur; }
           // set { this.fur = value; }
        }
        public Gender Gender
        {
            get { return this.gender; }
            //set { this.gender = value; }
        }
        private DateTime birthDay;

        public DateTime BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }

        public Rabbit(EyesColour eyes, FurColour fur, Gender gender, DateTime birthDay)
        {
            this.Eyes = eyes;
            //this.Fur = fur;
            //this.Gender = gender;
            this.BirthDay = birthDay;
        }

       
        

        public int Age
        {
            get
            {
                DateTime currentDate = DateTime.Today;
                int age = currentDate.Year - BirthDay.Year;

                if (currentDate.Month < BirthDay.Month || (currentDate.Month == BirthDay.Month && currentDate.Day < BirthDay.Day))
                {
                    age--;
                }
                return age;
            }
        }




        public string RabbitInfo()
        {
            return $"I`m an {Age} years old {gender} rabbit, I have {Eyes} eyes and {Fur} fur.";
        }

        public string Move()
        {
            return "This rabbit can move fast.";
        }

        public string Sleep()
        {
            return "I sleep when I`m tired.";
        }

        public string Eat()
        {
            return "I like to eat carrots.";
        }

    }




}
