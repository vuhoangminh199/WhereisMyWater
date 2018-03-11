using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class Map {

    [XmlArray("items")]
    [XmlArrayItem("item")]
    public List<MapObject> items = new List<MapObject>();
    public static Map Load(string path)
    {
        TextAsset textAsset = (TextAsset)Resources.Load(path, typeof(TextAsset));
        StringReader stringReader = new StringReader(textAsset.text);
        XmlTextReader reader = new XmlTextReader(stringReader);


        var serializer = new XmlSerializer(typeof(Map));
        return serializer.Deserialize(reader) as Map;
    }
    public static List<Map> LoadAll(string path)
    {
        TextAsset[] textAsset = Resources.LoadAll<TextAsset>(path);
        List<Map> list = new List<Map>();
        foreach (TextAsset ta in textAsset)
        {
            StringReader stringReader = new StringReader(ta.text);
            XmlTextReader reader = new XmlTextReader(stringReader);
            var serializer = new XmlSerializer(typeof(Map));
            Map mc = serializer.Deserialize(reader) as Map;
            list.Add(mc);
        }
        return list;
    }
    public void Save(string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Map));
        StreamWriter textWriter = new StreamWriter(path);
        serializer.Serialize(textWriter, this);
        textWriter.Close();
    }
}
