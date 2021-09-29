using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
  public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
       jumpForce = 100;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Jump"))
      {
            gameObject.GetComponent<Rigidbody>().AddForce
              (Vector3.up * jumpForce);
          }
     }
}
