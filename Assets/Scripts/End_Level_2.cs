﻿using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Level_2 : MonoBehaviour {

    //public GameObject scene;

    public InteractiveButton b;

	public GameObject box;

    public GameObject[] objects;

    public float speed = 1f;

    bool indicator = false;

    private void Update()
    {
        if (indicator) {
            Move();
        }
        Func();
    }

    public void Finish_Level() {
        indicator = true;
    }

    void Func() {
        if (b.gameObject.active==true) {
            indicator = false;
        }
    }

    public void Move() {

        objects[0].transform.position = Vector3.MoveTowards(objects[0].transform.position, new Vector3(-0.3f, 0, 1.8f), Time.deltaTime * speed);
        objects[0].transform.rotation = Quaternion.Euler(0, -90, 0);

        objects[1].transform.position = Vector3.MoveTowards(objects[1].transform.position, new Vector3(-0.3f, 0, 2f), Time.deltaTime * speed);
        objects[1].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[2].transform.position = Vector3.MoveTowards(objects[2].transform.position, new Vector3(-0.1f, 0, 2f), Time.deltaTime * speed);
        objects[2].transform.rotation = Quaternion.Euler(-90, -180, 90);

        objects[3].transform.position = Vector3.MoveTowards(objects[3].transform.position, new Vector3(-0.5f, 0.2f, 1.8f), Time.deltaTime * speed);
        objects[3].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[4].transform.position = Vector3.MoveTowards(objects[4].transform.position, new Vector3(-0.2f, 0.2f, 1.8f), Time.deltaTime * speed);
        objects[4].transform.rotation = Quaternion.Euler(0, 90, 0);

        objects[5].transform.position = Vector3.MoveTowards(objects[5].transform.position, new Vector3(-0.4f, 0.2f, 2.1f), Time.deltaTime * speed);
        objects[5].transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
