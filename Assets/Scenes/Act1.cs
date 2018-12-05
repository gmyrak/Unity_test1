using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act1 : MonoBehaviour {

    public GameObject cube1;
    public Light light1;

    float distant = 5;

    float x0;
    float y0;
    float z0;

    // Use this for initialization
    void Start () {
        print("Hello!");
        x0 = cube1.transform.position.x;
        y0 = cube1.transform.position.y;
        z0 = cube1.transform.position.z;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyUp(KeyCode.H))
        {            
            cube1.SetActive(!cube1.activeSelf);            
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            light1.enabled = !light1.enabled;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            cube1.GetComponent<Renderer>().material.color = Color.red;

        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            cube1.GetComponent<Renderer>().material.color = Color.green;

        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            cube1.GetComponent<Renderer>().material.color = Color.blue;

        }

        cube1.transform.position = new Vector3(x0, y0, z0 + distant*Input.GetAxis("Vertical"));

    }
}
