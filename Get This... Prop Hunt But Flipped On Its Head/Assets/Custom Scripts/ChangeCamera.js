#pragma strict


var propHunter : GameObject;
var firstPersonCamera : GameObject;
var thirdPersonCamera : GameObject;

function Start () {
	thirdPersonCamera.gameObject.active = false;
	firstPersonCamera.gameObject.active = true;
}

function Update () {
	if(Input.GetKeyDown(KeyCode.R)){
		if(thirdPersonCamera.gameObject.active){
			thirdPersonCamera.gameObject.active = false;
			firstPersonCamera.gameObject.active = true;
		} else {
			firstPersonCamera.gameObject.active = false;
			thirdPersonCamera.gameObject.active = true;
		}
	}
}