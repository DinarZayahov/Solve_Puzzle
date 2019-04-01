using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject obj;

    public HoloToolkit.Unity.Buttons.Button[] buttons;

    public Vector3[] positions;

    private void Update()
    {
        for (int i=0; i<buttons.Length; i++) {
            buttons[i].transform.position = obj.transform.TransformPoint(positions[i]);
            buttons[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x+i*90, obj.transform.rotation.eulerAngles.y, obj.transform.rotation.eulerAngles.z);
        }
    }

    public void Rotate_Up() { 
        obj.transform.Rotate(new Vector3(90, 0, 0));
    }

}
