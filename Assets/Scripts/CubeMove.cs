using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMove : MonoBehaviour {

    //public GameObject cube1;
    public float moveSpeed = 4.0f;
    public float turnSpeed = 40;
    public Text info;

    
    // Use this for initialization
	void Start () {
        //Instantiate(cube1, cube1.transform.position, cube1.transform.rotation);
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(v * Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Rotate(h * Vector3.up * turnSpeed * Time.deltaTime);

        Vector3 pos = transform.position;

        info.text = string.Format("x={0}\n" +
                                  "y={1}\n" +
                                  "z={2}", pos.x, pos.y, pos.z);


        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(this, this.transform.position + 2*Vector3.up, Quaternion.identity);
        }


    }
}
