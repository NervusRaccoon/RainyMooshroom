using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JappleGeneration : MonoBehaviour {
	
	public GameObject japples;
	public Texture2D image;
//	private Color myRed;
	void Start()
	{
	//	myRed = new Color (58f, 58f, 58f);
		int counter = 0;
		for (int i = 0; i < image.width; i++)
		{
			for (int j = 0; j < image.height; j++)
			{
				if (image.GetPixel(i,j) == Color.red)
				{
					var JappleGeneration = Instantiate (japples, new Vector3 (i, 1, j), Quaternion.identity);
					counter++;
					JappleGeneration.name = "japple" + counter;
				}
			}
		}
	}
}
