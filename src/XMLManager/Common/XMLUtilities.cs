using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Common
{
    public class XMLUtilities
    {
        private bool isValid = true;
        private ICollection<string> messages = new List<string>();

        public bool ValidateXML(string fileName, ICollection<string> messages = null)
        {
            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settings.XmlResolver = new XmlUrlResolver();

            // Create the XmlReader object.
            using (XmlReader reader = XmlReader.Create(fileName, settings))
            {
                // Parse the file. 
                while (reader.Read()) ;

                // Check whether the document is valid or invalid.
                if (isValid)
                    Console.WriteLine(String.Format("Document {0} is valid", fileName));
                else
                    Console.WriteLine(String.Format("Document {0} is invalid", fileName));
            }

            if (messages != null)
                messages = this.messages;

            return isValid;
        }

        public void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            isValid = false;
            Console.WriteLine("Validation event\n" + args.Message);
            messages.Add(args.Message);
        }

        public static T ReadFromXML<T>(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                T deserialized = (T)serializer.Deserialize(reader);

                return deserialized;
            }
        }

        public static XmlSerializerNamespaces GetComputerStoreNamespaces()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            return ns;
        }

        public static XmlWriterSettings GetComputerStoreXmlWriterSettings()
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = "\t";

            return writerSettings;
        }

        public static int GetNextXMLNumber(string folder)
        {
            return Directory.GetFiles(folder, "*.xml").Count();
        }
    }
}
