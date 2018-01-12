using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    #region Inspector Variables
    public ObjectPool  PoolRef;
    [SerializeField] private float _Speed = 10.0f;
    [SerializeField] public static float _Life = 3.0f;
    #endregion Inspector Variables

    #region Unity Methods

    private void Update()
    {
        transform.position += transform.forward * _Speed * Time.deltaTime;

        _Life -= Time.deltaTime;
        if (_Life <= 0.0f)
        {
            PoolRef.Release(gameObject);
        }
    }
    #endregion Unity Methods
}

