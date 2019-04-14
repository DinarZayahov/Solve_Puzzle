using UnityEngine;
using System.Collections.Generic;

public class BoxTransformer : MonoBehaviour {

	public float x = 0.1f;
	public float y = 0.1f;
	public float z = 0.1f;

	public Transform shape;


    // Arrays of buttons
    [Tooltip("4 buttons from top in clockwise direction")]
    public GameObject[] face_buttons = new GameObject[4];
    public GameObject[] right_buttons = new GameObject[4];
    public GameObject[] back_buttons = new GameObject[4];
    public GameObject[] left_buttons = new GameObject[4];
    public GameObject[] bottom_buttons = new GameObject[4];
    public GameObject[] top_buttons = new GameObject[4];

    [ContextMenu("Fire")]
	public void Fire(){

		shape.localScale = new Vector3(x,y,z);

        // Setting positions of buttons:

        face_buttons[0].transform.localPosition = new Vector3(0, y / 2 - 0.01f, -z / 2);
        face_buttons[1].transform.localPosition = new Vector3(x / 2 - 0.01f, 0, -z / 2);
        face_buttons[2].transform.localPosition = new Vector3(0, -(y / 2 - 0.01f), -z / 2);
        face_buttons[3].transform.localPosition = new Vector3(-(x / 2 - 0.01f), 0, -z / 2);

        right_buttons[0].transform.localPosition = new Vector3(x/2, y/2 - 0.01f, 0);
        right_buttons[1].transform.localPosition = new Vector3(x / 2, 0, z / 2 - 0.01f);
        right_buttons[2].transform.localPosition = new Vector3(x / 2, -(y / 2 - 0.01f), 0);
        right_buttons[3].transform.localPosition = new Vector3(x / 2, 0, -(z / 2 - 0.01f));

        back_buttons[0].transform.localPosition = new Vector3(0, y / 2 - 0.01f, z / 2);
        back_buttons[1].transform.localPosition = new Vector3(-(x / 2 - 0.01f), 0, z / 2);
        back_buttons[2].transform.localPosition = new Vector3(0, -(y / 2 - 0.01f), z / 2);
        back_buttons[3].transform.localPosition = new Vector3(x / 2 - 0.01f, 0, z / 2);

        left_buttons[0].transform.localPosition = new Vector3(- x / 2, y / 2 - 0.01f, 0);
        left_buttons[1].transform.localPosition = new Vector3(- x / 2, 0, -(z / 2 - 0.01f));
        left_buttons[2].transform.localPosition = new Vector3(- x / 2, -(y / 2 - 0.01f), 0);
        left_buttons[3].transform.localPosition = new Vector3(- x / 2, 0, z / 2 - 0.01f);

        bottom_buttons[0].transform.localPosition = new Vector3(0, y / 2, z / 2 - 0.01f);
        bottom_buttons[1].transform.localPosition = new Vector3(x / 2 - 0.01f, y/2, 0);
        bottom_buttons[2].transform.localPosition = new Vector3(0, y / 2, -(z / 2 - 0.01f));
        bottom_buttons[3].transform.localPosition = new Vector3(-(x / 2 - 0.01f), y/2, 0);

        top_buttons[0].transform.localPosition = new Vector3(0, - y / 2, -(z / 2 - 0.01f));
        top_buttons[1].transform.localPosition = new Vector3(x / 2 - 0.01f, -y / 2, 0);
        top_buttons[2].transform.localPosition = new Vector3(0, - y / 2, z / 2 - 0.01f);
        top_buttons[3].transform.localPosition = new Vector3(-(x / 2 - 0.01f), - y / 2, 0);

        // Setting the rotations of buttons:

        face_buttons[0].transform.localRotation = Quaternion.Euler(0, 0, 0);
        face_buttons[1].transform.localRotation = Quaternion.Euler(0, 0, -90);
        face_buttons[2].transform.localRotation = Quaternion.Euler(0, 0, 180);
        face_buttons[3].transform.localRotation = Quaternion.Euler(0, 0, 90);

        right_buttons[0].transform.localRotation = Quaternion.Euler(0, -90, 0);
        right_buttons[1].transform.localRotation = Quaternion.Euler(0, -90, -90);
        right_buttons[2].transform.localRotation = Quaternion.Euler(0, -90, 180);
        right_buttons[3].transform.localRotation = Quaternion.Euler(0, -90, 90);

        back_buttons[0].transform.localRotation = Quaternion.Euler(0, 0, 0);
        back_buttons[1].transform.localRotation = Quaternion.Euler(0, 0, 90);
        back_buttons[2].transform.localRotation = Quaternion.Euler(0, 0, 180);
        back_buttons[3].transform.localRotation = Quaternion.Euler(0, 0, -90);

        left_buttons[0].transform.localRotation = Quaternion.Euler(0, 270, 0);
        left_buttons[1].transform.localRotation = Quaternion.Euler(0, 270, 90);
        left_buttons[2].transform.localRotation = Quaternion.Euler(0, 270, 180);
        left_buttons[3].transform.localRotation = Quaternion.Euler(0, 270, -90);

        bottom_buttons[0].transform.localRotation = Quaternion.Euler(90, 0, 0);
        bottom_buttons[1].transform.localRotation = Quaternion.Euler(-90, -90, 0);
        bottom_buttons[2].transform.localRotation = Quaternion.Euler(-90, 0, 0);
        bottom_buttons[3].transform.localRotation = Quaternion.Euler(-90, 90, 0);

        top_buttons[0].transform.localRotation = Quaternion.Euler(-90, 0, 0);
        top_buttons[1].transform.localRotation = Quaternion.Euler(-90, -90, 0);
        top_buttons[2].transform.localRotation = Quaternion.Euler(90, 0, 0);
        top_buttons[3].transform.localRotation = Quaternion.Euler(90, -90, 0);
    }
}
