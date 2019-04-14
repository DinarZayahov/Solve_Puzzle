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

        // Hide the button
        button.gameObject.SetActive(false);

	}
	
	void Update () {

        // Counter for number of objects in Box
        int number_in_box = 0;

        // Check that objects from array of objects are in Box
        for (int i=0; i<objects.Length; i++) {
            if (InBox(objects[i])==true)
            {
                number_in_box++;
            }
        }

        // If all there, show button
        if (number_in_box == objects.Length)
        {
            button.gameObject.SetActive(true);
        }
        // Else hide it
        else {
            button.gameObject.SetActive(false);
        }
	}

    public bool InBox(GameObject obj) {

        float error = 0.04f;

        // Boundaries of box (with error):
        float x_l = box.transform.position.x - 0.2f - error;
        float x_r = box.transform.position.x + 0.2f + error;
        float y_u = box.transform.position.y + 0.2f + error;
        float y_d = box.transform.position.y - 0.2f - error;
        float z_f = box.transform.position.z - 0.2f - error;
        float z_b = box.transform.position.z + 0.2f + error;

        // Coordinates of endpoints of the diagonal
        float x1 = get_diagonal_point(obj).x;
        float y1 = get_diagonal_point(obj).y;
        float z1 = get_diagonal_point(obj).z;
        float x2 = get_opposite_diagonal_point(obj).x;
        float y2 = get_opposite_diagonal_point(obj).y;
        float z2 = get_opposite_diagonal_point(obj).z;
        
        // If all coordinates are inside of boundaries and no intersections between objects, return true, else false
        bool x = false;
        if (x1>=x_l && x1<=x_r && x2 >= x_l && x2 <= x_r) {
            x = true;
        }
        bool y = false;
        if (y1 >= y_d && y1 <= y_u && y2 >= y_d && y2 <= y_u)
        {
            y = true;
        }
        bool z = false;
        if (z1 >= z_f && z1 <= z_b && z2 >= z_f && z2 <= z_b)
        {
            z = true;
        }
        if (x && y && z && !Intersections()) {
            return true;
        }
        return false;
    }

    // Getting one endpoint of a diagonal
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

    // Getting another endpoint of a diagonal
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

    // Checking the intersection of colliders of objects
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
