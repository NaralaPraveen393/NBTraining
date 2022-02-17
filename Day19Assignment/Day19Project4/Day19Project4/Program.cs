using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number");
            int input=Convert.ToInt32(Console.ReadLine());
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\NBHtraining\\XML files\\Tag base XML.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode nodes in node.ChildNodes)
                {
                    bool ID=nodes.Name == "ID";
                    bool isIndex = (ID == true ? Convert.ToInt32(nodes.InnerText) : 0) == input;
                    if (ID && isIndex)
                    {
                        Console.WriteLine($"Product is {nodes.NextSibling.InnerText}");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
