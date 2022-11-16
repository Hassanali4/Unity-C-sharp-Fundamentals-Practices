using UnityEngine;


public class Player
{
    //instance members
    public string name;
    public int id;

    //static members
    public static int connectionCount = 0;

    public Player()
    {
        connectionCount++;
    }
}

public class TestnstanceMembersAndStaticMembers : MonoBehaviour
{

    private void Start()
    {
        /*
         * Personal Note: If these instances are created inside another class and then through a function of that class are executed
         * to show through debug.log(connectionCount++) it will show 2 times Player.connectionCount variables value for a single instance
         * inside another classs.
         */

        Player p1 = new Player();
        Player bread = new Player();
        Player Pistol = new Player();
        Player MachineGun = new Player();

        //This line of code will not work because a class can only have 1 static instance of it through out the whole life 
        // of a program when it starts running.
        //Debug.Log("Number of Players Connected"+ sword.numbersOfPlayersConnected);
        Debug.Log("Number of Players Connected : "+ Player.connectionCount);
        
    }

}
