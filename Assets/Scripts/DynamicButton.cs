using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity;
using System;

public class DynamicButton : MonoBehaviour {

    public GameObject box;

    public GameObject[] objects;

    public HoloToolkit.Unity.Buttons.Button button;

	void Start () {
        button.gameObject.SetActive(false);
	}
	
	void Update () {
        int number_in_box = 0;
        for (int i=0; i<objects.Length; i++) {
            if (InBox(objects[i])==true)
            {
                number_in_box++;
            }
        }
        if (number_in_box == objects.Length)
        {
            button.gameObject.SetActive(true);
        }
        else {
            button.gameObject.SetActive(false);
        }
	}

    public bool InBox(GameObject obj) {
        float x1 = get_diagonal_point(obj).x;
        float y1 = get_diagonal_point(obj).y;
        float z1 = get_diagonal_point(obj).z;
        float x2 = get_opposite_diagonal_point(obj).x;
        float y2 = get_opposite_diagonal_point(obj).y;
        float z2 = get_opposite_diagonal_point(obj).z;
        float error = 0.02f;
        bool x = false;
        if (x1>=-0.25f-error && x1<=-0.05f+error && x2 >= -0.25f-error && x2 <= -0.05f+error) {
            x = true;
        }
        bool y = false;
        if (y1 >= -0.1f - error && y1 <= 0.1f + error && y2 >= -0.1f - error && y2 <= 0.1f + error)
        {
            y = true;
        }
        bool z = false;
        if (z1 >= 1.4f - error && z1 <= 1.6f + error && z2 >= 1.4f - error && z2 <= 1.6f + error)
        {
            z = true;
        }
        if (x && y && z && !Intersections()) {
            return true;
        }
        return false;
    }

    public Vector3 get_diagonal_point(GameObject obj) {
        Vector3 diagonal_point = new Vector3(0, 0, 0);
        float half_of_width = obj.transform.lossyScale.x / 2;
        float half_of_length = obj.transform.lossyScale.z / 2;
        float half_of_height = obj.transform.lossyScale.y / 2;
        diagonal_point.x = obj.transform.position.x + half_of_width;
        diagonal_point.z = obj.transform.position.z + half_of_length;
        diagonal_point.y = obj.transform.position.y + half_of_height;
        return diagonal_point;
    }

    public Vector3 get_opposite_diagonal_point(GameObject obj)
    {
        Vector3 diagonal_point = new Vector3(0, 0, 0);
        float half_of_width = obj.transform.lossyScale.x / 2;
        float half_of_length = obj.transform.lossyScale.z / 2;
        float half_of_height = obj.transform.lossyScale.y / 2;
        diagonal_point.x = obj.transform.position.x - half_of_width;
        diagonal_point.z = obj.transform.position.z - half_of_length;
        diagonal_point.y = obj.transform.position.y - half_of_height;
        return diagonal_point;
    }

    public bool Intersections() {
        bool intersects = false;
        Collider[] colliders = new Collider[objects.Length];
        for (int i=0; i<objects.Length; i++) {
            Collider collider_1 = objects[i].GetComponent<Collider>();
            for (int j=i+1; j<objects.Length; j++) {
                Collider collider_2 = objects[j].GetComponent<Collider>();
                if (collider_1.bounds.Intersects(collider_2.bounds)) {
                    intersects = true;
                }
            }
        }
        if (intersects) {
            return true;
        }
        return false;
    }
}
