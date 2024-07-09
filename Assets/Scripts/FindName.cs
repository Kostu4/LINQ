using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FindName : MonoBehaviour
{
    private string[] names = {"John", "Tompson", "Kreks", "Yuto", "kostu4", "Leroy", "Djenkins", "Alis", "Josss", "IamFkingBoss", "Gerde2008s"};

    [ContextMenu("FindName")]
    void GetName()
    {
        string name = names.Where(x=>x.EndsWith("s")).OrderByDescending(x=>x.Length).FirstOrDefault();
        Debug.Log(JsonConvert.SerializeObject(name));
    }
}
