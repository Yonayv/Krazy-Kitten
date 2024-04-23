using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamerFollow : MonoBehaviour
{

    public float smoothTime = 0.25f;

    public Vector3 offset = new Vector3(0f, 0f, -10f);

    public float damping;

    public Vector3 velocity = Vector3.zero;

    [SerializeField] public Transform target;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 movePosiiton  = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, movePosiiton, ref velocity, damping);


    }
}
