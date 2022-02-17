using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19project1
{
    internal class Program
    {  //Author:Narala Praveen
        //Purpose:To read XML file in C#
        static void Main(string[] args)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\NBHtraining\\XML files\\Tag base XML.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                Console.WriteLine(text);
            } 
            Console.ReadLine(); 
        }  
    }
}
