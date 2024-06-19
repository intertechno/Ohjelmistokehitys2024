using System.Xml;

// read the XML file from disk
XmlDocument doc = new XmlDocument();
doc.Load("data.xml");

// create a new CSV file
using (StreamWriter writer = new StreamWriter("data.csv"))
{
    // write the header
    writer.WriteLine("Name,Email,Phone");

    // iterate over the nodes in the XML file
    foreach (XmlNode node in doc.SelectNodes("/users/user"))
    {
        // extract the data from the XML file
        string name = node.SelectSingleNode("name").InnerText;
        string email = node.SelectSingleNode("email").InnerText;
        string phone = node.SelectSingleNode("phone").InnerText;

        // write the data to the CSV file
        writer.WriteLine($"{name},{email},{phone}");
    }
}