using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x <= 14 && target.transform.position.x >= -15)
            gameObject.transform.position = target.position + offset;
        else
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,target.transform.position.y) + offset;
    }
}
