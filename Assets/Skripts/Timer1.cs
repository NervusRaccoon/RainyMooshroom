using UnityEngine;
using System.Collections;

public class Timer1 : MonoBehaviour {
	public int xs, ys;
	public int xm, ym;
	//do not edit
	public int timersecond;

	public float secondgametime = 0;
	private float secondgametimereset = 0;
	public float minedgametime = 0;
	private float minegametimereset = 0;
	public static float sec;
	public static float min;

	void Update () {
		bool finish = PlayersTrigger.Finish;
		if (finish == false) {
			//up game timer translate in second
			secondgametime += Time.deltaTime;
			if (secondgametime >= 1) {
				timersecond += 1;
			}
			if (secondgametime >= 1) {
				secondgametime = secondgametimereset;
			}
			//up second time translate into minutes
			if (timersecond >= 60) {
				minedgametime += 1;
				timersecond = 0;
			}
			if (minedgametime >= 60) {
				minedgametime = minegametimereset;
			}
		} else {
			sec = timersecond;
			min = minedgametime;
		}
	}

	void OnGUI (){

		GUI.Label(new Rect(Screen.width - xs,ys,100, 50), " " + timersecond);
		GUI.Label(new Rect(Screen.width - xm, ym, 100, 50), " " + minedgametime);
	}


}