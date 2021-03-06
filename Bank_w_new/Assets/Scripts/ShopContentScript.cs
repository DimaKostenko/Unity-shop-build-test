using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopContentScript : MonoBehaviour {

	public Transform shopContent;

	public enum PopularityValue
	{
		BestDeal,
		MostPopular
	}

	[System.Serializable]
	public struct BarValues
	{
		public int coinCount;
		public bool bonus;
		public int bonusCount;
		public float dollarCost;
		public bool popularity;
		public PopularityValue popularityValue;
	}

	public BarValues[] barList;

	public Sprite[] coinSprites;

	public Sprite bestDealSprite;
	public Font bestDealFont;


	void Start () {

		//Set shop values

		for (int i = 0; i < barList.Length; i++) {
			//Set coin count
			shopContent.GetChild (i).Find ("Coin_count_text").GetComponent<Text> ().text = barList[i].coinCount.ToString();

			//Set bonus count
			GameObject bonusObj = shopContent.GetChild (i).Find ("Bonus").gameObject;
			if (barList [i].bonus == true) {
				bonusObj.SetActive (true);
				bonusObj.transform.Find ("bonus_count_text").GetComponent<Text> ().text = barList [i].bonusCount.ToString ();
			} else {
				bonusObj.SetActive (false);
			}

			//Set dollar cost
			shopContent.GetChild (i).Find("Buy_Button").GetChild(0).GetComponent<Text> ().text = "$" + barList [i].dollarCost.ToString();

			//Set popularity
			GameObject popularityObj = shopContent.GetChild (i).Find ("Popularity").gameObject;
			if (barList [i].popularity == true) {
				popularityObj.SetActive (true);

				if (barList [i].popularityValue == PopularityValue.BestDeal) {
					popularityObj.transform.GetChild (0).gameObject.SetActive (true);
					popularityObj.transform.GetChild (1).gameObject.SetActive (false);
					popularityObj.transform.GetChild (0).Find ("Bg_Image").GetComponent<Animation> ().Play ();

					//Buy button setting
					//Sprite set
					shopContent.GetChild (i).Find("Buy_Button").GetComponent<Image>().sprite = bestDealSprite; 
					//Font set
					Text costText = shopContent.GetChild (i).Find ("Buy_Button").GetComponentInChildren<Text> ();
					costText.font = bestDealFont;
					costText.fontSize = 110;
				} else {
					popularityObj.transform.GetChild (0).gameObject.SetActive (false);
					popularityObj.transform.GetChild (1).gameObject.SetActive (true);
					popularityObj.transform.GetChild (1).Find ("Bg_Image").GetComponent<Animation> ().Play ();
				}
					
			} else {
				popularityObj.SetActive (false);
			}
	}
	
		//Sorting coin images
		for(int j = 0; j < barList.Length; j++){
			int value = 0;
			for(int k = 0; k < barList.Length; k++){
				if (barList [j].coinCount > barList [k].coinCount) {
					value++;	
				}
			}
			shopContent.GetChild (j).Find("Coin_icon").gameObject.GetComponent<Image>().sprite = coinSprites [value];
		}

	}
	
}
