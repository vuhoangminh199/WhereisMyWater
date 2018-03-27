using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

    private Map map;

    private string SAVE_MAP_PATH = "/Resources/Map/Map";
    private string SavePATH = "Map/";
    private string prefabsPath = "Prefabs/";
    public static MapController instance;

    void Start()
    {
        map = new Map();
        if (MenuInGame.level == 11) {
            InitMap(1);
        } else if (MenuInGame.level == 12) {
            InitMap(2);
        } else if (MenuInGame.level ==13){
            InitMap(3);
        } else if (MenuInGame.level ==14){
            InitMap(4);
        } else if (MenuInGame.level ==21){
            InitMap(5);
        }
        instance = this;
        //SaveMap
        // CreateMap(Application.dataPath + SAVE_MAP_PATH + "5.xml");

        //Load Map 
        //InitMap(1);
    }
    void Update(){
        // if (MenuInGame.level == 11) {
        //     InitMap(1);
        // } else if (MenuInGame.level == 12) {
        //     InitMap(2);
        // } else if (MenuInGame.level ==13){
        //     InitMap(3);
        // }
    }
    public void checkMap(){
        if (MenuInGame.level == 11) {
            InitMap(1);
            Debug.Log("1");
        } else if (MenuInGame.level == 12) {
            InitMap(2);
            Debug.Log("2");
        } else if (MenuInGame.level ==13){
            InitMap(3);
            Debug.Log("3");
        } else if (MenuInGame.level ==14){
            InitMap(4);
            Debug.Log("4");
        } else if (MenuInGame.level ==21){
            InitMap(5);
        }
    }

    void CreateMap(string path)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform Child = transform.GetChild(i);
            if (Child.tag == "finalTag")
            {
                if (MenuInGame.level == 13){
                    MapObject obj = new MapObject("finalObjectlv13", Child.position.x, Child.position.y);
                    map.items.Add(obj);
                } else if (MenuInGame.level == 21){
                    //                             Prefabs Name
                    MapObject obj = new MapObject("finalObject21", Child.position.x, Child.position.y);
                    map.items.Add(obj);
                }  else {
                    //                             Prefabs Name
                    MapObject obj = new MapObject("finalObject", Child.position.x, Child.position.y);
                    map.items.Add(obj);
                }  
            }
            if (Child.tag == "Wall")
            {
                MapObject obj = new MapObject("Wall", Child.position.x, Child.position.y);
                map.items.Add(obj);
            }
            if (Child.tag == "TileTop")
            {
                MapObject obj = new MapObject("tileTop", Child.position.x, Child.position.y);
                map.items.Add(obj);
            }
            if (Child.tag == "TileBottom")
            {
                MapObject obj = new MapObject("tileBottom", Child.position.x, Child.position.y);
                map.items.Add(obj);
            }
             if (Child.tag == "TileLeft")
            {
                MapObject obj = new MapObject("tileLeft", Child.position.x, Child.position.y);
                map.items.Add(obj);
            }
             if (Child.tag == "TileRight")
            {
                MapObject obj = new MapObject("tileRight", Child.position.x, Child.position.y);
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
            if (Child.tag == "lava")
            {
                AddListItem(Child, "DynamicParticle");
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
            if (item.Name=="finalObject"){
                Vector3 position = new Vector3(item.X, item.Y, -2);
                GameObject MapObject = Instantiate(obj);
                MapObject.transform.localScale = obj.transform.localScale;
                MapObject.transform.position = position;
                MapObject.transform.SetParent(transform);
            }
            if (item.Name=="finalObjectlv13"){
                Vector3 position = new Vector3(item.X, item.Y, -2);
                GameObject MapObject = Instantiate(obj);
                MapObject.transform.localScale = obj.transform.localScale;
                MapObject.transform.position = position;
                MapObject.transform.SetParent(transform);
            }
            if (item.Name=="finalObjectlv21"){
                Vector3 position = new Vector3(item.X, item.Y, -2);
                GameObject MapObject = Instantiate(obj);
                MapObject.transform.localScale = obj.transform.localScale;
                MapObject.transform.position = position;
                MapObject.transform.SetParent(transform);
            }
            if (obj != null)
            {
                Vector3 position = new Vector3(item.X, item.Y, 1);
                GameObject MapObject = Instantiate(obj);
                MapObject.transform.localScale = obj.transform.localScale;
                MapObject.transform.position = position;
                MapObject.transform.SetParent(transform);
            }
        }
        //todo change screen

    }
    public void RemoveMap()
    {
        foreach (Transform item in transform)
        {
            Destroy(item.gameObject);
        }
    }


}
