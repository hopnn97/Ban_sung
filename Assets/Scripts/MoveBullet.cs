using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Plane" && other.tag != "Player")
        {
            Destroy(other.gameObject);
        }
        Destroy(this.gameObject);
    }
}
