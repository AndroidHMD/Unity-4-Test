using UnityEngine;
using System.Collections;

public class PositionDebugger : MonoBehaviour {
	void Update () {
		Debug.Log(gameObject.name + " position: " + gameObject.transform.position);
	}
}