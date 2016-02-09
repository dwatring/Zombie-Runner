using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public void ManipulateTime (float newTime, float duration){

		if (Time.timeScale == 0) {
			Time.timeScale = 0.1f; //safety check. no zero times
		}
		StartCoroutine (FadeTo (newTime, duration));
	}

	IEnumerator FadeTo(float value, float time){

		for (float t = 0f; t < 1; t += Time.deltaTime / time) {
			Time.timeScale = Mathf.Lerp (Time.timeScale, value, t);

			if (Mathf.Abs (value - Time.timeScale) < .01f) {
				Time.timeScale = value;
				return false;
			}

			yield return null;
		}
	}
}
