using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit HitInfo;
        if (Physics.Raycast(ray,out HitInfo))
        {
            Debug.Log("Someting Else on down like " + HitInfo.transform.name); 
        }
		
	}
}
