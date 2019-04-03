using UnityEngine;

public class BoxTransformer : MonoBehaviour {

	public float x = 0.1f;
	public float y = 0.1f;
	public float z = 0.1f;

	public Transform shape;
	
	[ContextMenu("Fire")]
	public void Fire(){
		shape.localScale = new Vector3(x,y,z);
	}
}
