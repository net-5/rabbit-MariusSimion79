using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitHomework
{
    public enum EyesColour
    {
        blue,
        red,
        black
    }

    public enum FurColour
    {
        white,
        brown,
        black,
        grey
    }

    public enum Gender
    {
        male,
        female
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
            set { this.fur = value; }
        }
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        private int birthYear;

        public int BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }

        public Rabbit(EyesColour eyes, FurColour fur, Gender gender, int birthYear)
        {
            this.Eyes = eyes;
            this.Fur = fur;
            this.Gender = gender;
            this.BirthYear = birthYear;
        }

        public int Age()
        {
            return 2019 - birthYear;
        }

        public string RabbitInfo()
        {
            return $"I`m an {Age()} years old {gender} rabbit, I have {Eyes} eyes and {Fur} fur.";
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
