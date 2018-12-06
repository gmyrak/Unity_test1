using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Act1 : MonoBehaviour {

    public GameObject cube1;
    public Light light1;
    public Text txt;
    

    float distant = 5;
    float v = 1f;    

    Vector3 pos0;
    



    private void OnGUI()
    {
        GUI.Button(new Rect(10, 10, 150, 20), "Skinned Button");
        //GUI.
        //GUI.Label.s
    }


    // Use this for initialization
    void Start () {
        print("Hello!");
        pos0 = cube1.transform.position;
        //print(txt.GetType());


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

        //cube1.transform.position = new Vector3(x0, y0, z0 + distant*Input.GetAxis("Vertical"));

        

        //txt.text = "Hello. Canvas";

        //print(Input.gyro.gravity);
        //txt.text = Input.gyro.gravity.ToString();
        //txt.text = Input.gyro.

        Vector3 phone = Input.acceleration;
        

        
        //phone = new Vector3(1, 1, 1);
        txt.text = string.Format("x={0}\ny={1}\nz={2}", phone.x, phone.y, phone.z);


        cube1.transform.position += v * Time.deltaTime * (pos0 + distant*phone - cube1.transform.position).normalized;

        //v.normalized


    }
}
