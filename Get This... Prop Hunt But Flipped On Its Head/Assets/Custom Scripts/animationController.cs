using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class animationController : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
		float vertical = CrossPlatformInputManager.GetAxis("Vertical");

		anim.SetFloat ("horizontal", horizontal);
		anim.SetFloat ("vertical", vertical);

		if(Input.GetKeyDown("space")){
			anim.Play("JUMP00", -1, 0f);
		}

	}
}
