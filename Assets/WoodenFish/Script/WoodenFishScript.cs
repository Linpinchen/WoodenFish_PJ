using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodenFishScript : MonoBehaviour {
	public Button btn;
	public Button rest_Int;
	public Text txt;
	public int i;

	// Use this for initialization
	void Start ()
	{
		i = 0;

		btn.onClick.AddListener(delegate()
		{
			i++;
			txt.text = "功德數："+i;


		});


		rest_Int.onClick.AddListener(delegate ()
		{
			i=0;
			txt.text = "功德數：" + i;

		});



	}
	
	// Update is called once per frame
	void Update () {
		
	}











}
