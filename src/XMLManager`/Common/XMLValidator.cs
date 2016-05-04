using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Common
{
    public class XMLValidator
    {
        private static bool isValid = true;

        public static bool ValidateXML(string fileName)
        {
            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settings.XmlResolver = new XmlUrlResolver();

            // Create the XmlReader object.
            XmlReader reader = XmlReader.Create(fileName, settings);


            // Parse the file. 
            while (reader.Read()) ;

            // Check whether the document is valid or invalid.
            if (isValid)
                Console.WriteLine(String.Format("Document {0} is valid", fileName));
            else
                Console.WriteLine(String.Format("Document {0} is invalid", fileName));

            return isValid;
        }

        public static void ValidationCallBack(object sender,
                                            ValidationEventArgs args)
        {
            isValid = false;
            Console.WriteLine("Validation event\n" + args.Message);
        }

    }
}
