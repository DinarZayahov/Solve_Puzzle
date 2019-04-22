using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_to_1stLevel : MonoBehaviour {

    public GameObject main;

    public GameObject Scene_1;

    public void Go() {
        main.gameObject.SetActive(false);
        Scene_1.gameObject.SetActive(true);
    }
}
