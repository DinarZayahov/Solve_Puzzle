using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BoxTransformer : MonoBehaviour {

	public float x = 0.1f;
	public float y = 0.1f;
	public float z = 0.1f;

	public Transform shape;
	
	[ContextMenu("Fire")]
	public void Fire(){
		shape.localScale = new Vector3(x,y,z);
	}
}
