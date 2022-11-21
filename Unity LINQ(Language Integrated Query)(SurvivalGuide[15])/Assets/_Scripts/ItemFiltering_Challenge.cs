using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class item
{
    public string name;
    public int id;
    public int buff;
}

public class ItemFiltering_Challenge : MonoBehaviour
{
    /// <summary>
    /// Check if Item ID 3 exist in the list print out True OR False.
    /// Grabe all items with Buff greater then 20 and Print them  out.
    /// Calculate the average of all the buff stats.
    /// Using Linq Library
    /// </summary>

    public List<item> items;
    // Start is called before the first frame update
    void Start()
    {
        // Check if Item ID 3 exist in the list print out True OR False.
        var id3exist = items.Any(g => g.id == 3);//instructors code small & consiese "I need to think more about in line condition for single commands to execute
                                /*{//My code
                                    if (g.id == 3)
                                        return true;
                                    return false;
                                });*/
        Debug.Log(id3exist);

        /// Grabe all items with Buff greater then 20 and Print them  out.
        var itemWithBuffGreaterthen20 = items.Where(i => i.buff > 20);
        Debug.Log("Items that have Buff greater them 20.");
        foreach (var i in itemWithBuffGreaterthen20)
        {
            Debug.Log("Item : " + i.name);
        }

        //My rough and unsearched code to calculate average of all the buffs in item collection
        //var averageOfAllTheBuff = items.Where(i => i.buff != null).OrderByDescending(g => g.buff).Reverse().Average(i => i.buff);
        //Instructors code to collect all of the buffs average in item collection
        var averageOFAllTheBuffs = items.Average(i => i.buff);
        //NOTE:instructors code small & consiese "I need to think more about in line condition for single commands to execute
        Debug.Log("Average of all the Buff : " + averageOFAllTheBuffs);
    }
}
