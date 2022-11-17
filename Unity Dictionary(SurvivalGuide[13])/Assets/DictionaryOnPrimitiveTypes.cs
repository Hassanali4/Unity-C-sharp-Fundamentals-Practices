using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryOnPrimitiveTypes : MonoBehaviour
{
    public Dictionary<int, string> people = new Dictionary<int, string>();
    //public Dictionary<string, int> people = new Dictionary<int, string>(); //people in reverse
    public Dictionary<int, string> books = new Dictionary<int, string>();
    public Dictionary<bool, string> UnityQuize = new Dictionary<bool, string>();

    // Start is called before the first frame update
    void Start()
    {
        people.Add(25, "Hassan");
        people.Add(24, "Shoaib");
        people.Add(23, "Masood");
        people.Add(34, "Yin");

        //people in revers initialization
        /*people.Add("Hassan", 25);
        people.Add("Shoaib", 24);
        people.Add("Masood", 23);
        people.Add("Yin", 34);*/

        //This will print the whole Dictionary in sequencial order
        //To print a Dictionary complete we have to get it using KeyValuePaire keyword
        //with explaining it as Dictionary DataType syntax of <its kye data type,its Value data type
        /*foreach (KeyValuePair<int,string> person in people)
        {
            Debug.Log(person);
        }*/

        //reverse
        /*foreach (KeyValuePair<string, int> person in people)
        {
            Debug.Log(person);
        }*/

        //This will print only the Dictionary values in sequencial order this is simple as
        //All i need to think about is what will be its values data type are and only take them as reture value from dictionary.Values
        /*foreach (string person in people.Values)
        {
            Debug.Log(person);
        }*/

        //reverse
        /*foreach (string person in people.Keys)
        {
            Debug.Log(person);
        }*/

        //This will print only the Dictionary keys in sequencial order this is simple as
        //All i need to think about is what will be its keys data type are and only take them as reture value from dictionary.Keys
        /*foreach (int person in people.Keys)
        {
            Debug.Log(person);
        }*/

        //Reverse
        /*foreach (int person in people.Values)
        {
            Debug.Log(person);
        }*/

        ///summary
        ///Books example as Dictionary
        ///summary

        //assigning values
        books.Add(0, "Ultimate Game Developement Course with Unity");
        books.Add(1, "C # Unity Survival Guide");

        //Printing the whole Dictionary of books to the console
        /*foreach (KeyValuePair<int, string> book in books)
        {
            Debug.Log(book);
        }*/

        //Printing all Dictionary keys  of books to the console
        /*foreach (int book in books.Keys)
        {
            Debug.Log(book);
        }*/

        //Printing all Dictionary Values of books to the console
        /*foreach (string book in books.Values)
        {
            Debug.Log(book);
        }*/

        UnityQuize.Add(true, "One of the Unitys Advantage is that it helps save time when launching your game accross multiple plateforms.");
        Debug.Log(UnityQuize[true]);
        Debug.Log("Press 1 for True");
        Debug.Log("Press 2 for False");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Your Answer is Right!!");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Your Answer is Wrong!!");
        }
    }
}
