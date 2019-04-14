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
//efwef2w3f2f3
//ewff23r2f3r13d2r
///sacasdwqdqwd