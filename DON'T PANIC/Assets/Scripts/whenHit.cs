using UnityEngine;
using System.Collections;

public class whenHit : MonoBehaviour {

	public bool hitWithinLastThree;
	public bool colorOn;
	public Light dislight;
	public GameObject tv;
	private TimerScript timer;
	private int puzzlecount;
	public Material matneeded;
    

	// Use this for initialization
	void Start () {
		hitWithinLastThree = false;
		timer = tv.GetComponent<TimerScript>();
		
	}

	IEnumerator activeFor(float time)
	{
		hitWithinLastThree = true;
		yield return new WaitForSeconds (time);
		hitWithinLastThree = false;
	}

	IEnumerator correctColorActiveFor(float time)
	{
        dislight.intensity = 4;
        colorOn = true;
		timer.puzzlecounter++;
		yield return new WaitForSeconds (time);
        colorOn = false;
        timer.puzzlecounter--;
        dislight.intensity = 0;
    }

	public void hitByCorrectLaser()
	{
		StartCoroutine(correctColorActiveFor(3f));
	}

	
	// Update is called once per frame
	void Update () 
	{

			
	}
}
