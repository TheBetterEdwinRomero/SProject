using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Used provide an object with changing data
/// </summary>
public class BasicMover : MonoBehaviour {
    Vector3 v;
    // Use this for initialization
    void Start () {
        v = new Vector3(0, 0, 1);
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(v * Time.deltaTime);
        v.z += 0.1f;
	}
}
