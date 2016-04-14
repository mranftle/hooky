using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	private GameObject panel;
	private GameObject miniMap;
	private GameObject obj;
	private GameObject waterCanvas;
	private Text text;
	int counter = 0;
	string panelFlag = "";
	//enderer.enabled = true;


	// Use this for initialization
	void Start () {
		panel = GameObject.FindWithTag("panel");
		miniMap = GameObject.FindWithTag("MinimapCamera");
		waterCanvas = GameObject.FindWithTag("WaterCanvas");
		text = GameObject.FindWithTag("fb_text").GetComponent<Text>();
		obj = miniMap;
		Invoke("init1", 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		

	}



	void init1() {
		panel.SetActive (false);
		miniMap.SetActive (false);
		Invoke("init2", 0.2f);
		
	}

	void init2() {
		panel.SetActive (true);
		miniMap.SetActive (true);

		print ("counter:" + counter);
		counter++;
		if (counter < 3) {
			Invoke ("init1", 1.6f);
		} else if (counter == 3) 
		{
			text.text = "Water bar shows your remaning water.";
			Invoke("init3", 0f);
		}
		
		
	}
		
	void init3() {
		waterCanvas.SetActive (false);
		//miniMap.SetActive (true);
		Invoke("init4", 0.2f);
	}

	void init4() {
		waterCanvas.SetActive (true);
		//miniMap.SetActive (true);

		counter++;
		if (counter < 6) {
			Invoke("init3", 1.6f);
		} else if(counter == 6)
		{
			text.text = "You can move with arrow keys or WASD and run by Shift button. You can see entire map by pressing Tab";
			Invoke("init5", 8f);
			//init3 ();
		}
	}

	void init5() {
		panel.SetActive (false);
		//miniMap.SetActive (true);
	}




	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Solution"))
		{
			text.text = "Press space to collect homework solutions.";
			panel.SetActive (true);
			panelFlag = "Solution";
		}
	}

	void OnTriggerExit(Collider other)
	{
			//text.text = "Press space to collect homework solutions.";
		if(other.gameObject.tag == panelFlag)
		{
			panel.SetActive (false);
			panelFlag = "";
		}
	}



		


}
