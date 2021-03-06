using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinish : MonoBehaviour {

	public GameObject player;
	public GameObject enemy;
	public Texture2D image;
	public GameObject Mooshroom;
	void Start()
	{
		for (int i = 0; i < image.width; i++)
		{
			for (int j = 0; j < image.height; j++)
			{
				if (image.GetPixel(i, j) == Color.yellow)
				{
					//Debug.Log(image.GetPixel(i,j) == Color.red);
					var Finish = Instantiate (enemy, new Vector3 (i, 0, j), Quaternion.identity);
					Finish.name = "Enemy";
				}
				if (image.GetPixel(i,j) == Color.blue)
				{
					var Start = Instantiate (player, new Vector3(i, 0, j), Quaternion.identity);
					Start.name = "Player";
				}
				if (image.GetPixel(i, j) == Color.green)//!= Color.white) && (image.GetPixel(i, j) != Color.black)) 
				{
					var Finish = Instantiate (Mooshroom, new Vector3 (i, 0, j), Quaternion.identity);
					Finish.name = "Mooshroom";
				}
			}
		}
	}
}
