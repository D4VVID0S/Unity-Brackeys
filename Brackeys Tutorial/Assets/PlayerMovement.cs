using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate() // Use FixedUpdate instead of Update because it is better for Unity
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // Time.deltaTime to even out the advantage of more powerful pc's
    }
}
