using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Int2_to_Main : MonoBehaviour {

    public GameObject Int_2;

    public GameObject Main;

    public void Go()
    {
        Main.gameObject.SetActive(true);
        Int_2.gameObject.SetActive(false);
    }
}
