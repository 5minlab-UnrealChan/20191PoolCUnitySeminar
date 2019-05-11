using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /// <summary>
    /// 원본 게임 오브젝트
    /// </summary>
    public GameObject prefab;

    /// <summary>
    /// 초기에 만들어질 때 몇 개를 만들 것인가?
    /// </summary>
    public int initSize = 5;

    /// <summary>
    /// 풀링되는 오브젝트들을 관리
    /// </summary>
    private List<GameObject> usingObjectList = new List<GameObject>();

    private List<GameObject> unusedObjectList = new List<GameObject>();
    void Awake()
    {
        for (int i = 0; i < initSize; ++i)
        {
            var obj = Instantiate(prefab);
            obj.SetActive(false);
            unusedObjectList.Add(obj);
        }
    }

    /// <summary>
    /// 실제로는 키는 하는 역할을 맡음.
    /// </summary>
    public GameObject Instantiate(Vector3 pos, Quaternion rot)
    {
        if (unusedObjectList.Count == 0)
        {
            return null;
        }

        GameObject ret = unusedObjectList[0];
        ret.SetActive(true);
        ret.transform.SetPositionAndRotation(pos, rot);

        usingObjectList.Add(ret);
        unusedObjectList.Remove(ret);

        return ret;
    }

    /// <summary>
    /// 실제로는 끄는 역할
    /// </summary>
    public void Destroy(GameObject obj)
    {
        obj.SetActive(false);
        unusedObjectList.Add(obj);
        usingObjectList.Remove(obj);
    }
}
