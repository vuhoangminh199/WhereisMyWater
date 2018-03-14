using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class MapObject {

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("X")]
    public float X;
    [XmlAttribute("Y")]
    public float Y;

    MapObject()
    {
        Name = "Error";
        X = 0;Y = 0;
    }
    
    public MapObject(string nam, float posX, float poxY)
    {
        Name = nam;
        X = posX;
        Y = poxY;
    }

}
