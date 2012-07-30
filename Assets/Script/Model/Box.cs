using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	public UILabel boxLabel;
	public int start;
	public int destination;
	
	// Use this for initialization
	void Start () {
		boxLabel.text = start;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
