using UnityEngine;
using System.Collections.Generic;

public class BoxTransformer : MonoBehaviour {

	public float x = 0.1f;
	public float y = 0.1f;
	public float z = 0.1f;

	public Transform shape;

    [Tooltip("4 buttons from top in clockwize direction")]
    public GameObject[] face_buttons = new GameObject[4];
	
	[ContextMenu("Fire")]
	public void Fire(){
		shape.localScale = new Vector3(x,y,z);

        face_buttons[0].transform.localPosition = new Vector3(0, y / 2 - 0.01f, -z / 2);
        face_buttons[1].transform.localPosition = new Vector3(x / 2 - 0.01f, 0, -z / 2);
        face_buttons[2].transform.localPosition = new Vector3(0, -(y / 2 - 0.01f), -z / 2);
        face_buttons[3].transform.localPosition = new Vector3(-(x / 2 - 0.01f), 0, -z / 2);

    }
}
