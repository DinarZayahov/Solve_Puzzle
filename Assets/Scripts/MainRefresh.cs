using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRefresh : MonoBehaviour {

    [SerializeField]
    List<PositionRefresf> objects;
    
    public void Refresh()
    {
        objects.ForEach(x => x.Refresh());
    }
}
