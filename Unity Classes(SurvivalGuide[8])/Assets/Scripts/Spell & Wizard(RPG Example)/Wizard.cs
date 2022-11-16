using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell[] spells;

    public int level = 1;
    public int exp;

    private MeshRenderer _meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //To cast a specific spell according to the wizards level we will have to
                //Iterate through the spell list and compare to my current level
                //then cast Spell
            foreach (var spell in spells)
            {
                if ( spell.levelRequired == level )
                {
                    exp += spell.Cast();
                    Debug.Log("Now the Current Exp : " + exp);
                } else if ( spell.levelRequired == (level-1) )
                {

                    exp += spell.Cast();
                    Debug.Log("Current lvl did'nt have a spell so below lvl spell casted,Now the Current Exp : " + exp);
                }
            }
            
        }
        if (IncreaseLevel(exp,level))
        {
            level++;
        }
    }
    private bool IncreaseLevel(int exp,int level)
    {
        if (exp >= level * 100)
        {
            _meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
            return true;
        }
        return false;
    }

}

