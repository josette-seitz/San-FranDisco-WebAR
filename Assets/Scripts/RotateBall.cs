using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		iTween.RotateBy(this.gameObject, iTween.Hash("y", 2.0f, "time", 10.0f, "easetype", iTween.EaseType.linear));
	}
}
