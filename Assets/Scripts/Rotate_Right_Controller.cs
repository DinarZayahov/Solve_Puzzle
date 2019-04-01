using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Right_Controller : MonoBehaviour
{
    public GameObject obj;

    public HoloToolkit.Unity.Buttons.Button[] buttons;

    public Vector3[] positions;

    private void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].transform.position = obj.transform.TransformPoint(positions[i]);
            buttons[i].transform.rotation = Quaternion.Euler(obj.transform.rotation.eulerAngles.x, obj.transform.rotation.eulerAngles.y - 90*i, obj.transform.rotation.eulerAngles.z);
        }
    }

    public void Rotate_Right()
    {
        obj.transform.eulerAngles = new Vector3(0, obj.transform.localEulerAngles.y - 90, 0);
    }

}
