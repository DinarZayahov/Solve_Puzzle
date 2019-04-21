using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_Logo : MonoBehaviour {

    [Range(1f, 100f)]
    public float speed = 15f;

	void Update () {
        transform.Rotate(new Vector3(0, -Time.deltaTime*speed, 0));
	}
}
