using UnityEngine;
[System.Serializable]
public class Spell 
{
    public string Name;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;

    public Spell(string Name,int level,int itemIDRequired,int exp)
    {
        this.Name = Name;
        this.levelRequired = level;
        this.itemIdRequired = itemIDRequired;
        this.expGained = exp;
    }
    public int Cast()
    {

        Debug.Log("Casting " + this.Name);
        Debug.Log("Exp Gained : " + expGained);
        return expGained;
    }

}
