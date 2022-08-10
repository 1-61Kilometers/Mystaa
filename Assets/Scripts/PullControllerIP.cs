using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Xml;



/*
    The following code pulls the current computer's IPv4 address and 
    saves it to an XML file to be called upon later. If no IPV4 address
    can be found, an exception is thrown.
*/
public class PullControllerIP
{
    static public void Main(String[] args)
    {
        String currentIP = "";
        var host = Dns.GetHostEntry(Dns.GetHostName());

        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                currentIP = ip.ToString();
            }
        }

        if(currentIP == "")
        {
            throw new System.Exception("No IPv4 found.");
        }
        

        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.NewLineOnAttributes = true;

        using(XmlWriter writer = XmlWriter.Create("ControllerInfo.xml", settings))
        {
            writer.WriteStartElement("Controller");
            writer.WriteElementString("IP", currentIP);
            writer.WriteEndElement();
            writer.Close();
        }

    }
}
