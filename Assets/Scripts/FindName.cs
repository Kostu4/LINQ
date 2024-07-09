using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FindName : MonoBehaviour
{
    private string[] names = {"John", "Tompson", "Kreks", "Yuto", "kostu4", "Leroy", "Djenkins", "Alis", "Josss", "IamFkingBoss", "Gerde2008s"};
    private List<string> Search()
    { 
        List<string> searchedName = names.Where(x => x.EndsWith("s")).ToList();
        return searchedName;
    }
    private int Search2()
    {
        int longName = names.Max(x => x.Length);
        return longName;
    }

    [ContextMenu(nameof(GetName))]
    public void GetName()
    {
        Debug.Log(JsonConvert.SerializeObject(Search()));
        Debug.Log(JsonConvert.SerializeObject("The longest name has " + Search2() + " letters"));
    }
}
