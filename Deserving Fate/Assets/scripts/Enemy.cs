using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum EnemyType
//{
//    SLIME,
//    SQUELETON,
//    BAT
//}
public class Enemy : MonoBehaviour
{
    private float _moveSpeed;
    private int _direction;
    [SerializeField] private int _maxPoints;
    //private EnemyType _enemyType;
    [SerializeField] private Transform[] _patrolPoints;

    // Start is called before the first frame update
    void Start()
    {
        _moveSpeed = 1.5f;
        _direction = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _patrolPoints[_direction].position, _moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, _patrolPoints[_direction].position) < .2f)
        {
            if (_direction == _maxPoints)
            {
                _direction = 0;
            }
            else
            {
                _direction += 1;
            }
        }
        //if (_direction == 0)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, _patrolPoints[0].position, _moveSpeed * Time.deltaTime);
        //    if (Vector2.Distance(transform.position, _patrolPoints[0].position) < .2f)
        //    {
        //        _direction = 1;
        //    }
        //}

        //if (_direction == 1)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, _patrolPoints[1].position, _moveSpeed * Time.deltaTime);
        //    if (Vector2.Distance(transform.position, _patrolPoints[1].position) < .2f)
        //    {
        //        _direction = 0;
        //    }
        //}
    }
}
