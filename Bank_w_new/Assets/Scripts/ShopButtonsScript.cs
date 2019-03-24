using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonsScript : MonoBehaviour {

	public GameObject canvasObj;
	Animation anim;

	// Use this for initialization
	void Start () {
		anim = canvasObj.GetComponent<Animation> ();
	}

	public void ShopOpen(){
		anim.Play ("Coin_shop_open");
	}

	public void ShopClose(){
		anim.Play ("Coin_shop_close");
	}
}
//Stroke changed