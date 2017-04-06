using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class TextController : MonoBehaviour {

public Text text;
private enum States {start, f_cell, t_cell, w_cell};
private enum Race {undefined, fighter, thief, wizard};
private States myState;
private Race myRace;
	

	


	

	// Use this for initialization
	void Start () {
		myState = States.start;
		myRace = Race.undefined;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start)		{start ();}
		if (myState == States.f_cell)		{f_cell ();}
		if (myState == States.t_cell)		{t_cell ();}
		if (myState == States.w_cell)		{w_cell ();}
		}
	//Section 1 - start to corridor_hatch
	void start () {
		text.text = ("You are held prisoner onboard a ship bound for the Kingdom ") +
					("of Ravenmarch. Questions of innocence aside, it seems that ") +
					("fate has smiled upon you today. The time of your escape is ") +
					("nigh...\n\nWho are you?\n\nPress F for Fighter, T for Thief ") +
					("or W for Wizard.");
					
		if (Input.GetKeyDown (KeyCode.F))		{myRace = Race.fighter;}
		if (Input.GetKeyDown (KeyCode.T))		{myRace = Race.thief;}
		if (Input.GetKeyDown (KeyCode.W))		{myRace = Race.wizard;}	
		if (myRace == Race.fighter) 			{myState = States.f_cell;}
		if (myRace == Race.thief)				{myState = States.t_cell;}
		if (myRace == Race.wizard)				{myState = States.w_cell;}		
	}
	
	void f_cell () {
		text.text = ("Fighter");
	
	}
	
	void t_cell () {
		text.text = ("Thief");
		
	}
	
	void w_cell () {
		text.text = ("Wizard");
		
	}
}