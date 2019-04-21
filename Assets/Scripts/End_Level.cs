using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Level : MonoBehaviour {

    public GameObject box;

    public GameObject[] objects;

    public float speed = 1f;

    bool indicator = false;

    private void Update()
    {
        if (indicator) {
            Move();
        }
    }

    public void Finish_Level() {
        indicator = true;
    }

    public void Move() {
        float x = box.transform.position.x;
        float y = box.transform.position.y;
        float z = box.transform.position.z;
        GameObject face = GameObject.Find("Face");
        float s = face.transform.localScale.x;
        objects[0].transform.position = Vector3.MoveTowards(objects[0].transform.position, new Vector3(x, y - s / 4, z), Time.deltaTime * speed);
        objects[0].transform.rotation = Quaternion.Euler(0, 0, 0);
        
        objects[1].transform.position = Vector3.MoveTowards(objects[1].transform.position, new Vector3(x - s / 4, y + s / 4, z), Time.deltaTime * speed);
        objects[1].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[2].transform.position = Vector3.MoveTowards(objects[2].transform.position, new Vector3(x + s / 4, y + s / 4, z - s / 4), Time.deltaTime * speed);
        objects[2].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[3].transform.position = Vector3.MoveTowards(objects[3].transform.position, new Vector3(x + s / 4, y + s / 4, z + s / 4), Time.deltaTime * speed);
        objects[3].transform.rotation = Quaternion.Euler(0, 0, 0);
    }

}
