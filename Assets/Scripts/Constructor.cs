using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour {

    // Box
    //public GameObject box;

    // Sides of a Box
    public GameObject[] sides;

    // Scaling of a Box
    public float scale;

    [ContextMenu("Construct")]
    public void Construct() {

        //float scale = box.transform.lossyScale.x;

        float error = scale / 50;

        // Setting the scales of sides
        sides[0].transform.localScale = new Vector3(scale, scale, scale/100);
        sides[1].transform.localScale = new Vector3(scale/100, scale, scale);
        sides[2].transform.localScale = new Vector3(scale, scale, scale/100);
        sides[3].transform.localScale = new Vector3(scale / 100, scale, scale);
        sides[4].transform.localScale = new Vector3(scale, scale/100, scale);

        // Setting the positions of sides
        sides[0].transform.localPosition = new Vector3(0,0,-(scale/2+error));
        sides[1].transform.localPosition = new Vector3(scale/2+error, 0, 0);
        sides[2].transform.localPosition = new Vector3(0, 0, scale / 2+error);
        sides[3].transform.localPosition = new Vector3(-(scale/2+error), 0, 0);
        sides[4].transform.localPosition = new Vector3(0, -(scale / 2+error), 0);
    }
}
