using System.Linq;
using UnityEngine;

public class Any_Keywords_Usage : MonoBehaviour
{
    public string[] names = { "Masood" , "Jibran" , "Sherry", "Ahmad" , "Asim" , "Subhani" , "Shoaib" };

    // Start is called before the first frame update
    void Start()
    {
        //Linq - Any Keyword Example
        //var nameFound = names.Any(name => name == "Shery");

        //Linq - Contains Keyword Example
        var nameFound = names.Contains("Asi");

        Debug.Log("Name Found : " + nameFound);
        /*foreach (var name in names)
        {
            if (name == "Asim")
                Debug.Log("Name Found :" + name);
        }*/
    }
}
