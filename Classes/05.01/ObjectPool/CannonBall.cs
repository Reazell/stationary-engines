using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {
    [SerializeField] private float _Speed = 10.0f;
    [SerializeField] private float _Life = 3.0f;
    public ObjectPool _Pool;
    private void Update()
    {
        transform.position += transform.forward * _Speed * Time.deltaTime;

        _Life -= Time.deltaTime;
        if(_Life <= 0.0f)
        {
            var reference = GetComponent<PoolReference>();
            if(reference != null)
            {
                reference.Pool.Release(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            _Pool.Release(gameObject);
        }
    }

    
}
