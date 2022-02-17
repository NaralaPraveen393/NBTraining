using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project2
{   //Author:Narala Praveen
    //Purpose:To print only name from XML file
    internal class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\NBHtraining\\XML files\\Tag base XML.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    if (node2.Name == "Name")

                        Console.WriteLine(node2.InnerText);
                }
               
            }
            Console.ReadLine();

        }
    }
}
