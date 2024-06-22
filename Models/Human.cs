using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Human
    {
        //fields
        private static int nextId = 1;
        private string name;
        private DateTime dateOfBirth;
        private string address;
        private double height;
        private double weight;
        //properties
        [Key] public int HumanId { get; set; }
        public string Name
        {
            get { return name; }
            set {name = value;}
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //contructors
        public Human(string name, DateTime dateOfBirth, string address, double height, double weight)
        {
            HumanId = nextId++;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            Height = height;
            Weight = weight;
        }

        //method
        public virtual string ToString()
        {
            return $"ID: {HumanId};\nName: {Name};\nDateOfBirth: {DateOfBirth};\nAddress: {Address};\nHeight: {Height};\nWeight: {Weight}";
        }
    }
}
