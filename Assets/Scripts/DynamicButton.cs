using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity;
using System;
using HoloToolkit.Examples.InteractiveElements;

public class DynamicButton : MonoBehaviour {

    // Main box where we should  put our objects
    public GameObject box;

    // Non-complex objects
    public GameObject[] objects;

    // Complex objects which contain several cubes
    public GameObject[] complex_objects;

    // Buttons that we need to hide and show
    public GameObject[] buttons;

    

    void Start()
    {

        // Hide the button
        foreach (GameObject o in buttons) {
            o.gameObject.SetActive(false);
        }
        //cofe.gameObject.SetActive(false);
        pack();
        Debug.Log("Number of elements"+list.Count.ToString());


    }

    List<GameObject> list = new List<GameObject>();

    // Put every cubes (including the ones which inside of complex objects) to the List
    void pack()
    {
        foreach (GameObject o in complex_objects)
        {
            foreach (Transform child in o.transform)
            {
                list.Add(child.gameObject);
            }
        }
        foreach (GameObject o in objects)
        {
            list.Add(o);

        }
    }

    void Update () {

        // Counter for number of objects in Box
        int number_in_box = 0;

        // Check that objects from array of objects are in Box
        for (int i=0; i<list.Count; i++) {
            if (InBox(list[i])==true)
            {
                number_in_box++;
            }
        }

        // If all there, show button
        if (number_in_box == list.Count)
        {
            foreach (GameObject o in buttons)
            {
                o.gameObject.SetActive(true);
            }
        }
        // Else hide it
        else {
            foreach (GameObject o in buttons)
            {
                o.gameObject.SetActive(false);
            }
        }
	}


    public bool InBox(GameObject obj) {

        GameObject edge_of_box = GameObject.Find("Face");
        float scale = edge_of_box.transform.localScale.x;
        float error = scale / 6;
        float offset = scale / 2 + error;

        // Boundaries of box (with error):
        float x_l = box.transform.position.x - offset;
        float x_r = box.transform.position.x + offset;
        float y_u = box.transform.position.y + offset;
        float y_d = box.transform.position.y - offset;
        float z_f = box.transform.position.z - offset;
        float z_b = box.transform.position.z + offset;

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
        Collider[] colliders = new Collider[list.Count];
        for (int i=0; i<list.Count; i++) {
            Collider collider_1 = list[i].GetComponent<Collider>();
            for (int j=i+1; j<list.Count; j++) {
                Collider collider_2 = list[j].GetComponent<Collider>();
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
