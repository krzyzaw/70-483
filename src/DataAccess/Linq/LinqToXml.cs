using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DataAccess.Linq
{
    public class LinqToXml
    {
        public static void Test()
        {
            string XMLText = "<MusicTracks>" +
                                "<MusicTrack>" +
                                    "<Artist>Rob</Artist>" +
                                    "<Title>My Way</Title>" +
                                    "<Length>150</Length>" +
                                "</MusicTrack>" +
                                "<MusicTrack>" +
                                    "<Artist>Immy</Artist>" +
                                    "<Title>His Way</Title>" +
                                    "<Length>200</Length>" +
                                "</MusicTrack>" +
                             "</MusicTracks>";


            XDocument musicTracDocument = XDocument.Parse(XMLText);
            IEnumerable<XElement> selectedElements = musicTracDocument.Descendants("MusicTrack").Select(track => track);

            //filter xml
            IEnumerable<XElement> filterElements = musicTracDocument.Descendants("MusicTrack")
                                                    .Where(x => (string)x.Element("Artist") == "Rob")
                                                    .Select(track => track);

            //Add new XElement
            foreach (var selectedElement in selectedElements)
            {
                selectedElement.Add(new XElement("Style", "Pop"));
            }

            //Modify Xml
            foreach (var selectedElement in selectedElements)
            {
                selectedElement.Element("Title").FirstNode.ReplaceWith("Test");
            }
        }

        public static void CreateXmlUsingLinq()
        {
            XElement musicTracks = new XElement("MusicTracks", new List<XElement>()
            {
                new XElement("MusicTrack",
                    new XElement("Artist", "Rob"),
                    new XElement("Title", "My Way")),
                new XElement("MusicTrack",
                    new XElement("Artist", "Immy"),
                    new XElement("Title", "His Way"))
            });
        }
    }
}