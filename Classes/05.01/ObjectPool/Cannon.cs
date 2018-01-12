using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    #region Inspector Variables
    [SerializeField] private GameObject _Projectile;
    [SerializeField] public ObjectPool _Pool;
    #endregion

    #region Unity Methods
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }
    #endregion

    #region Private Methods
    private void Shoot()
    {
        var obj = _Pool.Request();
        obj.GetComponent<CannonBall>().PoolRef = _Pool;
        obj.transform.position = transform.position;
    }
    #endregion
}

