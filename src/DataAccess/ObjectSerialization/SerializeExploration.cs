using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using MusicStore.Entities;

namespace DataAccess.ObjectSerialization
{
    public class SerializeExploration
    {
        public static void SerializeToBinary(List<MusicTrack> musicTracks)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream outputStream = new FileStream("MusicTracks.bin", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(outputStream, musicTracks);
            }
        }

        public static void SerializeToXml(List<MusicTrack> musicTracks)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<MusicTrack>));
            using (FileStream outputStream = new FileStream("MusicTracks.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(outputStream, musicTracks);
            }
        }
    }
}