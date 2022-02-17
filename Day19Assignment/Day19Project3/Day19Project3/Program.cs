using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\NBHtraining\\XML files\\Tag base XML.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode nodes in node.ChildNodes)
                {
                    if (nodes.Name == "ID")
                    {
                        Console.Write(nodes.InnerText+", ");
                    }
                    if (nodes.Name == "Name")

                    {
                        Console.Write(nodes.InnerText+", ");
                    }
                    if (nodes.Name == "Price")
                    {
                        Console.Write($"{nodes.InnerText}\n");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
