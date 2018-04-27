using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeThrower : MonoBehaviour {

    public GameObject CubePrefabs;

	// Use this for initialization
	void Start () {
        //Invoke("CreateCube", 2);
        InvokeRepeating("CreateCube", 2, 1);
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Go = Instantiate(CubePrefabs);
            Go.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * 1000);
            Destroy(Go, 3);


        }
       
    }
    void CreateCube()
    {
        GameObject Go = Instantiate(CubePrefabs);
        Go.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * 1000);
        Destroy(Go, 3);
    }
}
