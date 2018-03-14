using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

    private Map map;

    private string SAVE_MAP_PATH = "/Resources/Map/Map";
    private string SavePATH = "Map/";
    private string prefabsPath = "Prefabs/";

    void Start()
    {
        map = new Map();

        //SaveMap
        CreateMap(Application.dataPath + SAVE_MAP_PATH + "1.xml");

        //Load Map
        //InitMap(1);
    }

    void CreateMap(string path)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform Child = transform.GetChild(i);
            if (Child.tag == "finalTag")
            {
                //                             Prefabs Name
                MapObject obj = new MapObject("finalObject", Child.position.x, Child.position.y);
                map.items.Add(obj);
            }
            if (Child.tag == "Wall")
            {
                MapObject obj = new MapObject("Wall", Child.position.x, Child.position.y);
                map.items.Add(obj);
            }
            if (Child.tag == "Duck")
            {
                AddListItem(Child, "Duck");
            }
            if (Child.tag == "water")
            {
                AddListItem(Child, "DynamicWater");
            }
            if (Child.tag == "Dirt")
            {
                AddListItem(Child, "Dirt");
            }
        }
        map.Save(path);
    }
    void AddListItem(Transform trans,string Name)
    {
        for (int i = 0; i < trans.childCount; i++)
        {
            Transform Child = trans.GetChild(i);
            MapObject obj = new MapObject(Name, Child.position.x, Child.position.y);
            map.items.Add(obj);
        }
    }

    public void InitMap(int index)
    {
        RemoveMap();
        map = Map.Load(SavePATH + "Map" + index);
        foreach (MapObject item in map.items)
        {
            GameObject obj;
            if (item.Name=="Wall")
               obj = (GameObject)Resources.Load(prefabsPath+"Map/" + item.Name +index, typeof(GameObject));
            else
                obj = (GameObject)Resources.Load(prefabsPath + item.Name, typeof(GameObject));
            if (obj != null)
            {
                Vector3 position = new Vector3(item.X, item.Y, 1);
                GameObject MapObject = Instantiate(obj);
                MapObject.transform.localScale = obj.transform.localScale;
                MapObject.transform.position = position;
                MapObject.transform.SetParent(transform);
            }
        }
    }
    public void RemoveMap()
    {
        foreach (Transform item in transform)
        {
            Destroy(item.gameObject);
        }
    }


}
