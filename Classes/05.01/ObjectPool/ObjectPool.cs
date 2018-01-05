using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour {
    [SerializeField] public GameObject objectToPool;

    public GameObject Request()
    {
        var obj = _Pool.FirstOrDefault();
        if(obj != null)
        {
            _Pool.Remove(obj);
            obj.SetActive(true);
            return obj;
        }
        obj = Instantiate(objectToPool);
        return obj;
    }

    public void Release(GameObject obj)
    {
        _Pool.Add(obj);
        obj.SetActive(false);
    }

    private readonly List<GameObject> _Pool = new List<GameObject>();

}
