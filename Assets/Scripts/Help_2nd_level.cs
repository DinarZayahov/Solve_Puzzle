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
        float x = box.transform.position.x;
        float y = box.transform.position.y;
        float z = box.transform.position.z;
        GameObject face = GameObject.Find("Face");
        float s = face.transform.localScale.x;

        objects[2].transform.position = Vector3.MoveTowards(objects[2].transform.position, new Vector3(x - s / 3, y - s / 6, z - s / 6), Time.deltaTime * speed);
        objects[2].transform.rotation = Quaternion.Euler(0, 0, 90);

        objects[4].transform.position = Vector3.MoveTowards(objects[4].transform.position, new Vector3(x - s / 6, y + s / 6, z + s / 3), Time.deltaTime * speed);
        objects[4].transform.rotation = Quaternion.Euler(90, 0, 0);

        /**objects[2].transform.position = Vector3.MoveTowards(objects[2].transform.position, new Vector3(x - s / 6, y + s / 3, z - s / 6), Time.deltaTime * speed);

        objects[3].transform.position = Vector3.MoveTowards(objects[3].transform.position, new Vector3(x + s / 3, y + s / 6, z - s / 3), Time.deltaTime * speed);
        objects[3].transform.rotation = Quaternion.Euler(90, 0, 0);

        objects[4].transform.position = Vector3.MoveTowards(objects[4].transform.position, new Vector3(x + s / 3, y + s / 3, z + s / 3), Time.deltaTime * speed);

        objects[5].transform.position = Vector3.MoveTowards(objects[5].transform.position, new Vector3(x + s / 3, y + s / 3, z), Time.deltaTime * speed);*/

        objects[1].transform.position = Vector3.MoveTowards(objects[1].transform.position, new Vector3(x + s / 3, y - s / 3, z), Time.deltaTime * speed);
        objects[1].transform.rotation = Quaternion.Euler(0, 180, 0);

        objects[0].transform.position = Vector3.MoveTowards(objects[0].transform.position, new Vector3(x, y - s / 3, z), Time.deltaTime * speed);

        objects[3].transform.position = Vector3.MoveTowards(objects[3].transform.position, new Vector3(x + s / 3, y, z), Time.deltaTime * speed);
        objects[3].transform.rotation = Quaternion.Euler(180, 90, 0);
    }
}