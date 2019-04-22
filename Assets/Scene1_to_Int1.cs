using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_to_Int1 : MonoBehaviour {

    public GameObject Int1;

    public GameObject Scene_1;

    public void Go()
    {
        Int1.gameObject.SetActive(true);
        Scene_1.gameObject.SetActive(false);
    }
}
