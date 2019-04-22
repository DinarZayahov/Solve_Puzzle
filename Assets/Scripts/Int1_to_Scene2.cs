using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Int1_to_Scene2 : MonoBehaviour {

    public GameObject Int1;

    public GameObject Scene_2;

    public void Go()
    {
        Int1.gameObject.SetActive(false);
        Scene_2.gameObject.SetActive(true);
    }
}
