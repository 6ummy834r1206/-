using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHup : MonoBehaviour {
    public GameObject Target;
    public float Posy;
    public float Posx;
    public float Posz;
    // Use this for initialization
    void Start () {
        Posx = Target.GetComponent<Transform>().position.x;
        Posy = Target.GetComponent<Transform>().position.y;
        Posz = Target.GetComponent<Transform>().position.z;
    }
	
	// Update is called once per frame
	void Update () {

        Target.GetComponent<Transform>().position = new Vector3(Posx, Mathf.Lerp(Posy-9f, Posy+12, Mathf.PingPong(Time.time*0.3f, 1)), Posz);
    }
}
