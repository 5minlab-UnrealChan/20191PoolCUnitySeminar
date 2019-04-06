using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    private float time =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Mathf.PingPong(Time.time, 1f);
        Debug.Log(time);
        transform.position = Vector3.Lerp(new Vector3(-1.25f, transform.position.y, transform.position.z), new Vector3(5.25f, transform.position.y, transform.position.z), time);
    
    }
}
