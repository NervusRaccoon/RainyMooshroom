using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMapGeneration : MonoBehaviour {
	
	public GameObject trees;
	public Texture2D image;
	void Start()
	{
		int counter = 0;
		for (int i = 0; i < image.width; i++)
		{
			for (int j = 0; j < image.height; j++)
			{
				if (image.GetPixel(i,j) == Color.white)
				{
					var TreeGeneration = Instantiate (trees, new Vector3 (i, 0, j), Quaternion.identity);
					counter++;
					TreeGeneration.name = "TreeObstacle" + counter;
				}
			}
		}
	}
}
