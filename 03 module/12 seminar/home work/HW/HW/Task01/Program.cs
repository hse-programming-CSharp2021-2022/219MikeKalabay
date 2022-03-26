using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Task01
{
    [Serializable]
    [XmlInclude(typeof(Professor)), XmlType]
    public class Human
    {
        public Human() { }

        [DataMember]
        public string name;

        public Human(string name)
        {
            this.name = name;
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor() { }

        public Professor(string name) : base(name) { }
    }

    [Serializable]
    [XmlInclude(typeof(List<Human>)), XmlType]
    public class Department
    {
        public Department() { }

        [DataMember]
        public string name;

        [DataMember]
        public List<Human> humans;

        public Department(string name)
        {
            this.name = name;
            humans = new List<Human>();
        }
    }

    [Serializable]
    [XmlInclude(typeof(List<Department>)), XmlType]
    public class University
    {
        public University() { }

        [DataMember]
        public string name;

        [DataMember]
        public List<Department> departaments;

        public University(string name, List<Department> departaments)
        {
            this.name = name;
            this.departaments = departaments;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Human> a = new List<Human>() { new Human("1"), new Professor(name: "1"), new Human("2") };
            Department b = new Department("1");
            Department c = new Department("2");
            b.humans = a;
            c.humans = a;
            List<University> d = new List<University>() { new University("1", new List<Department> { b, c }), new University("2", new List<Department> { b, c }) };

            DataContractJsonSerializer format = new DataContractJsonSerializer(typeof(List<University>));
            using (FileStream wr = new FileStream("output.json", FileMode.OpenOrCreate))
            {
                format.WriteObject(wr, d);
            }

            XmlSerializer format2 = new XmlSerializer(typeof(List<University>));
            using (FileStream wr = new FileStream("output.xml", FileMode.OpenOrCreate))
            {
                format2.Serialize(wr, d);
            }

            BinaryFormatter formater3 = new BinaryFormatter();
            using (FileStream wr = new FileStream("output.bin", FileMode.OpenOrCreate))
            {
                formater3.Serialize(wr, d);
            }
        }
    }
}