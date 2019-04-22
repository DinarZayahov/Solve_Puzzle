using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Level_2 : MonoBehaviour {

    public GameObject scene;

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
        if (scene.gameObject.active==false) {
            indicator = false;
        }
    }

    public void Move() {
        float x = box.transform.position.x;
        float y = box.transform.position.y;
        float z = box.transform.position.z;
        GameObject face = GameObject.Find("Face");
        float s = face.transform.localScale.x;
        
        objects[0].transform.position = Vector3.MoveTowards(objects[0].transform.position, new Vector3(x - s / 3, y - s / 6, z - s / 6), Time.deltaTime*speed);
        objects[0].transform.rotation = Quaternion.Euler(0, 0, 90);

        objects[1].transform.position = Vector3.MoveTowards(objects[1].transform.position, new Vector3(x - s / 6, y + s / 6, z + s / 3), Time.deltaTime * speed);
        objects[1].transform.rotation = Quaternion.Euler(90,0,0);

        objects[2].transform.position = Vector3.MoveTowards(objects[2].transform.position, new Vector3(x - s / 6, y + s / 3, z - s / 6), Time.deltaTime * speed);
        objects[2].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[3].transform.position = Vector3.MoveTowards(objects[3].transform.position, new Vector3(x + s / 3 + 0.02f, y + s / 6, z - s / 3), Time.deltaTime * speed);
        objects[3].transform.rotation = Quaternion.Euler(90,0,0);

        objects[4].transform.position = Vector3.MoveTowards(objects[4].transform.position, new Vector3(x + s / 3, y + s / 3, z + s / 3), Time.deltaTime * speed);
        objects[4].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[5].transform.position = Vector3.MoveTowards(objects[5].transform.position, new Vector3(x + s / 3, y + s / 3, z), Time.deltaTime * speed);
        objects[5].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[6].transform.position = Vector3.MoveTowards(objects[6].transform.position, new Vector3(x + s / 3, y - s / 3, z-0.03f), Time.deltaTime * speed);
        objects[6].transform.rotation = Quaternion.Euler(0,180,0);

        objects[7].transform.position = Vector3.MoveTowards(objects[7].transform.position, new Vector3(x, y - s / 3, z), Time.deltaTime * speed);
        objects[7].transform.rotation = Quaternion.Euler(0, 0, 0);

        objects[8].transform.position = Vector3.MoveTowards(objects[8].transform.position, new Vector3(x + s / 3, y, z), Time.deltaTime * speed);
        objects[8].transform.rotation = Quaternion.Euler(180,90,0);
    }
}
