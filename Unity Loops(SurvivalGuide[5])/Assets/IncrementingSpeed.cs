using System.Collections;
using UnityEngine;

public class IncrementingSpeed : MonoBehaviour
{
    /// <summary>
    /// Create a program where you increment the value of speed by 5  every second -- when speed is greater
    /// then MaxSpeed ,stop incrementing Rendomize MaxSpeed(between 60 to 120)
    /// Hint use a coroutine
    /// </summary>
    [SerializeField]
    private int _speed = 0;
    [SerializeField]
    private int _maxSpeed = 60;
    private void Start()
    {
        _maxSpeed = Random.Range(60, 121);
        StartCoroutine(IncRoutine());
    }
    
    
    IEnumerator IncRoutine()
    {
        while (true)
        {
            if (_speed > _maxSpeed)
                break;
            _speed += 5;
            yield return new WaitForSeconds(1f);
        }
    }
}
