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
        List<string> searchedName = names.Where(x => x.EndsWith("s")).OrderByDescending(x => x.Length).Take(1).ToList();
        return searchedName;
    }

    [ContextMenu(nameof(GetName))]
    public void GetName()
    {
        Debug.Log(JsonConvert.SerializeObject(Search()));
    }
}
