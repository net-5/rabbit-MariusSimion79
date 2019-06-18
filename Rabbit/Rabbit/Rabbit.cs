using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    class Rabbit
    {

        public string Eyes { get; set; }
        public string Fur { get; set; }
        public string Gender { get; set; }
        public int BirthDate { get; set; }

        public string ShowInfo()
        {
            return $"I have {Eyes} eyes, a {Fur} fur and I`m an {2019 - BirthDate} years old {Gender} rabbit.";
        }

        public string DisplayAge()
        {
            return $"This rabbit has {(2019 - BirthDate).ToString()} years old.";
        }

        public string Move()
        {
            return "I`m an rabbit and I can move.";
        }

        public string Sleep()
        {
            return "I sleep alot.";
        }

        public string Eat()
        {
            return "I`m an rabbit and I eat carrots.";
        }
    }
}
