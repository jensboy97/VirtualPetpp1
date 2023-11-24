using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace ConsoleApp1;


    internal class character
    {
        public int petId;
        public string name;

         public int age;

        public string gender;
        public character(int petId, string name, int age, string gender)
        {
            this.petId = petId;
            this.name = name;
            this.age = age;
            this.gender = gender; 
        }

        public character(string name)
        {
            this.name = name;
        }


    }

