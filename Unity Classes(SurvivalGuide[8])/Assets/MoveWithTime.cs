using UnityEngine;

public class MoveWithTime : MonoBehaviour
{
    [SerializeField] private int _timeAfterChangingDirection;// Time if will take to change the direction
    [SerializeField] private int _direction;//an integer variable to adjust the sign of positive & negative after certain amount of time
    [SerializeField] private float _moveSpeed = 2;// speed of movemnt
    [SerializeField] private int count;// the internal counter that counts after how much certain amount it will reecet the movement by checking with _timeAfterChangingDirection Variable
    
    void Start()
    { 
        _direction = 1;
    }

    void Update()
    {
        count += 1;
            this.transform.position = this.transform.position + new Vector3(_direction * _moveSpeed * Time.deltaTime, _direction * _moveSpeed * Time.deltaTime, 0f);
        if (count > _timeAfterChangingDirection)
        {
            count = 0;
            _direction = -1 * _direction;
        }

    }
}
