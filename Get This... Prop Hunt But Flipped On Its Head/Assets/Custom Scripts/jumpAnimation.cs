using UnityEngine;
using System.Collections;

public class jumpAnimation : MonoBehaviour {

	public Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			anim.Play("JUMP01", -1, 0f);
			print ("jumped");
		}


	}
	
}
