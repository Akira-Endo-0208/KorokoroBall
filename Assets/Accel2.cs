using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel2 : MonoBehaviour
{
    public float AccelPower = 100.0f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(AccelPower, 0, 0));
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
