using System.Linq;
using UnityEngine;

public class LinqExample_Distinct : MonoBehaviour
{
    public string[] names = { "Masood", "Masood", "Jibran", "Sherry", "Salman", "Subhani", "Salman", "Shoaib", "Subhani", "Zeeshan", "Zeeshan" };
    // Start is called before the first frame update
    void Start()
    {
        //Using the linqs Distinct Extension without parameters which returns an IEnumerable which is a collection of data 
        var uniqueNames = names.Distinct();
        foreach (var name in uniqueNames)
        {
            Debug.Log("Name : " + name);
        }
    }
}
