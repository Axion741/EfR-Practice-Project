using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class TextController : MonoBehaviour {

public Text text;
private enum States {start, f_cell, t_cell, w_cell, cell, listen, cell_door, cell_open,
					corridor, floor,corridor_hatch, upper_hatch, lower_hatch,
					lower_storage_0, lamp_0, body, exit_hatch_0, body_key_0,
					lower_storage_1, body_key_1, lamp_1, exit_hatch_1, galley_hatch,
					f_galley, fight_scene, mace, knife, w_galley, galley_safe,
					t_galley, t_equipment, t_fight_scene, t_galley_safe, t_galley_door,
					equipment, galley_door, deck_doorway, deck_boxes, deck_guard, boat_up_0,
					boat_down, rowing, beach, escape, upper_hatch_open, upper_storage_0,
					behind_boxes_0, treasure, upper_storage_1, behind_boxes_1, upper_door_0,
					upper_door_1, upper_deck_door, upper_deck, upper_guard, boat_up_1};

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
		if (myState == States.start)				{start ();}
		if (myState == States.f_cell)				{f_cell ();}
		if (myState == States.t_cell)				{t_cell ();}
		if (myState == States.w_cell)				{w_cell ();}
		if (myState == States.cell)					{cell ();}
		if (myState == States.listen)				{listen ();}
		if (myState == States.cell_door)			{cell_door ();}
		if (myState == States.cell_open)			{cell_open ();}
		if (myState == States.corridor)				{corridor ();}
		if (myState == States.floor)				{floor ();}
		if (myState == States.corridor_hatch)		{corridor_hatch ();}
		//Lower Route States
		if (myState == States.lower_hatch)			{lower_hatch ();}
		if (myState == States.lower_storage_0)		{lower_storage_0 ();}
		if (myState == States.lamp_0)				{lamp_0 ();}
		if (myState == States.body)					{body ();}
		if (myState == States.exit_hatch_0)			{exit_hatch_0 ();}
		if (myState == States.body_key_0)			{body_key_0 ();}
		if (myState == States.lower_storage_1)		{lower_storage_1 ();}
		if (myState == States.body_key_1)			{body_key_1 ();}
		if (myState == States.lamp_1)				{lamp_1 ();}
		if (myState == States.exit_hatch_1)			{exit_hatch_1 ();}
		if (myState == States.galley_hatch)			{galley_hatch ();}
		if (myState == States.f_galley)				{f_galley ();}
		if (myState == States.fight_scene)			{fight_scene ();}
		if (myState == States.mace)					{mace ();}
		if (myState == States.knife)				{knife ();}
		if (myState == States.w_galley)				{w_galley ();}
		if (myState == States.galley_safe)			{galley_safe ();}
		if (myState == States.equipment)			{equipment ();}
		if (myState == States.galley_door)			{galley_door ();}
		if (myState == States.t_galley)				{t_galley ();}		
		if (myState == States.t_equipment)			{t_equipment ();}
		if (myState == States.t_fight_scene)		{t_fight_scene ();}
		if (myState == States.t_galley_safe)		{t_galley_safe ();}
		if (myState == States.t_galley_door)		{t_galley_door ();}
		if (myState == States.deck_doorway)			{deck_doorway ();}
		if (myState == States.deck_boxes)			{deck_boxes ();}
		if (myState == States.deck_guard)			{deck_guard ();}
		if (myState == States.boat_up_0)			{boat_up_0 ();}
		//Upper Route States
		if (myState == States.upper_hatch)			{upper_hatch ();}
		if (myState == States.upper_hatch_open)		{upper_hatch_open ();}
		if (myState == States.upper_storage_0)		{upper_storage_0 ();}
		if (myState == States.behind_boxes_0)		{behind_boxes_0 ();}
		if (myState == States.upper_door_0)			{upper_door_0 ();}
		if (myState == States.treasure)				{treasure ();}
		if (myState == States.upper_storage_1)		{upper_storage_1 ();}
		if (myState == States.behind_boxes_1)		{behind_boxes_1 ();}
		if (myState == States.upper_door_1)			{upper_door_1 ();}
		if (myState == States.upper_deck_door)		{upper_deck_door ();}
		if (myState == States.upper_deck)			{upper_deck ();}
		if (myState == States.upper_guard)			{upper_guard ();}
		if (myState == States.boat_up_1)			{boat_up_1 ();}
		//End States
		if (myState == States.boat_down)		{boat_down ();}
		if (myState == States.rowing)		{rowing ();}
		if (myState == States.beach)		{beach ();}
		if (myState == States.escape)		{escape ();}
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