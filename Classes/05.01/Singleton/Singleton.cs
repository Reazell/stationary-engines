using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T _instance;

    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                var obj = new GameObject
                {
                    name = "Singleton <" + typeof(T).Name + ">"
                };
                _instance = obj.AddComponent<T>();
            }
            return _instance;
            
        }
    }


}
