using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class SpineboyAnimController : MonoBehaviour {

	SkeletonGraphic skeletonAnimation;

	// Use this for initialization
	void Start () {
		skeletonAnimation = GetComponent<SkeletonGraphic> ();
	}
	
	// Update is called once per frame
	public void GunTossAnim () {
		skeletonAnimation.AnimationState.SetAnimation (0, "gun toss", true);
	}
}
//dsaqwefef7
//dsfewfwef23f
