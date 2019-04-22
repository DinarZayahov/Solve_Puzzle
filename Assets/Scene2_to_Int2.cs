using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2_to_Int2 : MonoBehaviour {

    public GameObject Int2;

    public GameObject Scene_2;

    public void Go()
    {
        Int2.gameObject.SetActive(true);
        Scene_2.gameObject.SetActive(false);
    }
}
