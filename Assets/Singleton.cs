using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Singleton>();
                if (instance == null)
                {
                    instance = new GameObject().AddComponent<Singleton>();
                }
            }
            return instance;
        }
    }

    // 사용 예시
    //Singleton.Instance.~~~;
}
