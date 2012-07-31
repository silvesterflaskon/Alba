using System;
using System.Collections;
using UnityEngine;

public class Box : MonoBehaviour {
	public TextMesh boxLabel;
	public GameObject boxModel;	
	public int start;
	public int destination;
	public bool isShowed;
	
	protected Transform OriginalPos;
	
	protected int boxFingerID = -1;
	
	// Use this for initialization
	void Start () 
	{
		boxLabel.text = start.ToString();
		OriginalPos = boxModel.transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if(isShowed)
//		{
			boxLabel.text = start.ToString();
//		}
//		else
//		{
//			boxLabel.text = "";
			
			foreach (Touch touch in Input.touches)
			{
				if (touch.phase == TouchPhase.Began)
				{
					boxFingerID = touch.fingerId;
					boxModel.transform.position = touch.position;				

				} else if (touch.phase == TouchPhase.Stationary)
				{
					boxFingerID = touch.fingerId;
					boxModel.transform.position = touch.position;				
				} else if (touch.phase == TouchPhase.Moved)
				{
					boxFingerID = touch.fingerId;
					boxModel.transform.position = touch.position;				
				} else if (touch.phase == TouchPhase.Ended)
				{
					boxFingerID = touch.fingerId;
					boxModel.transform.position = touch.position;				
				}
			}
//		}
	}
}
