using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {
    [SerializeField] public GameObject cannonBall;
    [SerializeField] private ObjectPool _Pool;

	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }

	}

    private void Shoot()
    {
        var obj = _Pool.Request();
        obj.AddComponent<PoolReference>().
        obj.transform.position = transform.position;
    }
}
