using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    #region Public Methods

    public GameObject Request()
    {
        var obj = _Pool.FirstOrDefault();
        if (obj != null)
        {
            _Pool.Remove(obj);
            obj.SetActive(true);
            return obj;
        }

        obj = Instantiate(_Prefab);
        return obj;
    }
    public void Release(GameObject obj)
    {
        obj.SetActive(false);
        CannonBall._Life = 3.0f;
        _Pool.Add(obj);
    }
    #endregion 

    #region Inspector Variables
    [SerializeField] private GameObject _Prefab;
    #endregion 


    #region Private Variables
    private readonly List<GameObject> _Pool = new List<GameObject>();
    #endregion 
}