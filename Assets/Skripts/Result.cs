using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	public int xs, ys;
	private Text lvl1, lvl2, lvl3, lvl4, lvl5;
	public int xm, ym;
	private bool finish;

void Awake()
    {
        // Load the Arial font from the Unity Resources folder.
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        // Create Canvas GameObject.
        GameObject canvasGO = new GameObject();
        canvasGO.name = "Canvas";
        canvasGO.AddComponent<Canvas>();
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();

        // Get canvas from the GameObject.
        Canvas canvas;
        canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Create the Text GameObject.
		GameObject text1 = new GameObject("TimeRecord1");
        text1.transform.parent = canvasGO.transform;
        text1.AddComponent<Text>();

		GameObject text2 = new GameObject("TimeRecord2");
		text2.transform.parent = canvasGO.transform;
		text2.AddComponent<Text>();

		GameObject text3 = new GameObject("TimeRecord3");
		text3.transform.parent = canvasGO.transform;
		text3.AddComponent<Text>();

		GameObject text4 = new GameObject("TimeRecord4");
		text4.transform.parent = canvasGO.transform;
		text4.AddComponent<Text>();

		GameObject text5 = new GameObject("TimeRecord5");
		text5.transform.parent = canvasGO.transform;
		text5.AddComponent<Text>();

        // Set Text component properties.
        lvl1 = text1.GetComponent<Text>();
        lvl1.font = arial;
        lvl1.fontSize = 45;
        lvl1.alignment = TextAnchor.MiddleCenter;

		lvl2 = text2.GetComponent<Text>();
		lvl2.font = arial;
		lvl2.fontSize = 45;
		lvl2.alignment = TextAnchor.MiddleCenter;

		lvl3 = text3.GetComponent<Text>();
		lvl3.font = arial;
		lvl3.fontSize = 45;
		lvl3.alignment = TextAnchor.MiddleCenter;

		lvl4 = text4.GetComponent<Text>();
		lvl4.font = arial;
		lvl4.fontSize = 45;
		lvl4.alignment = TextAnchor.MiddleCenter;

		lvl5 = text5.GetComponent<Text>();
		lvl5.font = arial;
		lvl5.fontSize = 45;
		lvl5.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.

		lvl1.GetComponent<RectTransform> ().localPosition = new Vector3 (13, 116, 0);
        lvl1.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 100);

        lvl2.GetComponent<RectTransform> ().localPosition = new Vector3 (13, 60, 0);
        lvl2.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 100);

        lvl3.GetComponent<RectTransform> ().localPosition = new Vector3 (13, 0, 0);
        lvl3.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 100);

		lvl4.GetComponent<RectTransform> ().localPosition = new Vector3 (13, -66, 0);
		lvl4.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 100);

		lvl5.GetComponent<RectTransform> ().localPosition = new Vector3 (13, -136, 0);
		lvl5.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 100);


    }

	void Update()
	{
		finish = PlayersTrigger.Finish;
		//GUI.Label(new Rect(Screen.width - xs,ys, 100, 50), " " + Timer.sec);
		//GUI.Label(new Rect(Screen.width - xm, ym, 100, 50), " " + Timer.min);
		if (finish == true) {
			lvl1.text = "" + Timer1.min + ":" + Timer1.sec;
			lvl2.text = "" + Timer2.min + ":" + Timer2.sec;
			lvl3.text = "" + Timer3.min + ":" + Timer3.sec;
			lvl4.text = "" + Timer4.min + ":" + Timer4.sec;
			lvl5.text = "" + Timer5.min + ":" + Timer5.sec;
		}
	}
}
