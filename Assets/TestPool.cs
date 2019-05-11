using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPool : MonoBehaviour
{
    ObjectPool pool;

    List<GameObject> poolList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        pool = GetComponent<ObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (poolList.Count > 5)
            {
                poolList.Add(pool.Instantiate(Vector3.zero, Quaternion.identity));
            }

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (poolList.Count != 0)
            {
                pool.Destroy(poolList[0]);
                poolList.RemoveAt(0);
            }

        }
    }
}
