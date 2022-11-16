using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum LevelSelector
{
    Easy, // 0 //Also i can initialize value to it as my need like (Easy = 22)
    Normal,// 1
    Hard,// 2
    GodMode,// 3
}

public class DifficultyScript : MonoBehaviour
{
    ///summary
    ///Normaly enums are variables names with values associated with them
    ///like we need to make variable values for levels in a game so that we can have settings of the game setted 
    ///according to them for this purpose anyone can use the variable approach like show below
    ///public int easylevel = 0;
    ///public int noramllevel = 1;
    ///public int hardlevel = 2;
    ///public int GodModelevel = 3;
    ///
    /// But this will add 4 lines of code & 4 variables to keep track of making the logic 
    ///summary

    ///summary
    ///But enums make these 4 lines of code not less as you need to describe parts of the level in enums 
    ///but give you the convienent to track only 1 variable 
    ///
    ///and you can focus on making logic with single variable focusing on the levels part only.
    ///Also using switch statements with it makes soo much logical sense with it.
    ///
    ///Which makes the coding much more logical and sensible
    ///summary
    ///

    public LevelSelector currentLevel;

    private void Start()
    {
        
            switch (currentLevel)
            {
                case LevelSelector.Easy:
                    Debug.Log("Easy Level Selected");
                SceneManager.LoadScene((int)currentLevel);
                    break;
                case LevelSelector.Normal:
                    Debug.Log("Noraml Level Selected");
                    SceneManager.LoadScene((int)currentLevel);
                    break;
                case LevelSelector.Hard:
                    Debug.Log("Hard Level Selected");
                    SceneManager.LoadScene((int)currentLevel);
                    break;
                case LevelSelector.GodMode:
                    Debug.Log("GodeMode Level Selected");
                    SceneManager.LoadScene((int)currentLevel);
                    break;
            }
        
    } // End of Update


}
