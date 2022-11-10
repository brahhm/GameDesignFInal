using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody playerRb;
    private float zBound = 9;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

      transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
      transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
      
      if (transform.position.z < -zBound)
      {
        transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
      }
      if (transform.position.z > zBound)
      {
        transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
      }

      
    }
}
