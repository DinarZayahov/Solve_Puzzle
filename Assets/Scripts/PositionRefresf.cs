using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRefresf : MonoBehaviour {
    
    Vector3 pos;
    Quaternion ori;
    
    // Use this for initialization
	void Awake () {
        pos = transform.position;
        ori = transform.rotation;
    }

    public void Refresh()
    {
        transform.position = pos;
        transform.rotation = ori;
    }
}
