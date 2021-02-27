using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent1 : MonoBehaviour
{
    private GameObject snitch;

    // Start is called before the first frame update
    void Start()
    {
        snitch = GameObject.Find("Snitch");
    }


    private void Update()
    {
 
    }



    public float attractForce = 3.0f;
    void FixedUpdate()
    {
        Vector3 direction = snitch.transform.position - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce(attractForce * direction);

    }
}
