using HoloToolkit.Examples.InteractiveElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help_2nd_level : MonoBehaviour
{
    public InteractiveButton b;

    public GameObject box;

    public GameObject[] objects;

    public float speed = 1f;

    bool indicator = false;

    private void Update()
    {
        if (indicator)
        {
            Move();
        }
        Func();
    }

    void Func()
    {
        if (b.gameObject.activeSelf == true)
        {
            indicator = false;
        }
    }

    public void Pack()
    {
        indicator = true;
    }

    public void Move()
    {
        objects[0].transform.position = Vector3.MoveTowards(objects[0].transform.position, new Vector3(-0.3f, -0.1f, 2.1f), Time.deltaTime * speed);
        objects[0].transform.rotation = Quaternion.Euler(90, 0, 0);

        //objects[1].transform.position = Vector3.MoveTowards(objects[1].transform.position, new Vector3(-0.1f, -0.1f, 2.1f), Time.deltaTime * speed);
        //objects[1].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[2].transform.position = Vector3.MoveTowards(objects[2].transform.position, new Vector3(-0.5f, -0.3f, 2.1f), Time.deltaTime * speed);
        objects[2].transform.rotation = Quaternion.Euler(180, 0, -90);

        //objects[3].transform.position = Vector3.MoveTowards(objects[3].transform.position, new Vector3(-0.2f, -0.2f, 1.9f), Time.deltaTime * speed);
        //objects[3].transform.rotation = Quaternion.Euler(-90, 0, 0);
    }
}