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
		if (myState == States.boat_down)			{boat_down ();}
		if (myState == States.rowing)				{rowing ();}
		if (myState == States.beach)				{beach ();}
		if (myState == States.escape)				{escape ();}
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
		text.text = ("With a naturally brawny physique and years of dedicated ") +
					("training, you have become a respected and successful sword ") +
					("for hire across the land.\n\nUnfortunately danger comes with the ") +
					("territory, and this particular job could have gone better.\n\n") +
					("Press W to wake up.");
		
		if (Input.GetKeyDown (KeyCode.W))		{myState = States.cell;}
	}
	
	void t_cell () {
		text.text = ("While some would call you a thief, you prefer to see your ") +
					("self as an entrepreneur.\n\nAdmittedly your methods may be a ") +
					("touch unorthodox, and you know more about lockpicking than ") +
					("is probably healthy, but you’ve done well for yourself until  ") +
					("this particular setback.\n\nPress W to wake up.");
		
		if (Input.GetKeyDown (KeyCode.W))		{myState = States.cell;}		
	}
	
	void w_cell () {
		text.text = ("Born with the rare gift of magical ability, your skills have ") +
					("brought you both power and peril from a young age.\n\nIt would ") +
					("now seem that the dangers of your bloodline have caught up ") +
					("with you, as you sail towards unknown lands and an unknown  ") +
					("future.\n\nPress W to wake up.");
					
		if (Input.GetKeyDown (KeyCode.W))		{myState = States.cell;}
	}
					
					
	void cell() {
		text.text = ("You have awoken to the violent sway of a choppy sea, your ") +
					("lower body icy cold from submersion in the foot of water ") +
					("that covers the cell floor.\n\nStrange sounds seem to be emanating ") +
					("from beyond the ship’s hull, and the wooden door of your cell ") +
					("rattles against its lock.\n\nPress L to listen to the sounds outside,") +
					("or press D to inspect the cell door.");
		
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.listen;}
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.cell_door;}	
	}
	
	void listen() {
		text.text = ("The sounds beyond the wooden hull of the ship are muffled ") +
					("and distorted. It seems likely that you are below the water line.\n\n") +
					("It is possible that you are hearing the sound of explosions above.") +
					("\n\nPress R to return.");
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.cell;}
				
	}	
	
	void cell_door() {
		text.text = ("As you make you way over to the door, you can hear sounds ") +
					("of wood crashing and splintering somewhere above in the ship.\n\n") +
					("You look out through the tiny, barred window of the cell just in ") +
					("time to see the wall of the opposite cell explode into shrapnel!\n\n") +
					("You fall backwards as the door slams into you, momentarily dazed.") +
					("\n\nPress U to get back up.");
					
		if (Input.GetKeyDown (KeyCode.U))		{myState = States.cell_open;}
	
	}
	
	void cell_open() {
		text.text = ("The cell door is now swinging open. On closer inspection you see") +
					("a small cannonball lodged in the metal lock mechanism.") +
					("\n\n A lucky escape indeed!\n\nPress C to enter the corridor");
					
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.corridor;}

	}
	
	void corridor() {
		text.text = ("The corridor outside the cell is similarly waterlogged, not ") +
					("helped by the torrent of water now spewing in from the hole ") +
					("left by your lucky cannonball.\n\nAt the end of the corridor you ") +
					("can see a ladder that seems to be lead to a hatch in the ceiling.\n\n") +
					("Press F to look around on the floor, L to move to the ladder, ") +
					("Or C to return to your cell.");
					
		if (Input.GetKeyDown (KeyCode.F))		{myState = States.floor;}
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.corridor_hatch;}
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.cell_open;}
	
	}
	
	void floor() {
		text.text = ("You quickly try to look around on the floor, but the churning ") +
					("waters make it difficult to make anything out.\\You are made  ") +
					("acutely aware of how quickly the water level is rising however.\n\n") +
					("Press R to return.") ;
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.corridor;}

	}
	
	void corridor_hatch() {
		text.text = ("Here you can see two hatches, one set into the floor and ") +
					("the other in the roof.\n\nThe lower hatch is below the water line, while the upper ") +
					("hatch sports a large padlock, presumably to deter escaping prisoners.\n\n") +
					("Press L to open the lower hatch, or U to try to open the upper hatch.");
					
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.lower_hatch;}
		if (Input.GetKeyDown (KeyCode.U))		{myState = States.upper_hatch;}
		
	}
	//Lower Route//
	void lower_hatch() {
		text.text = ("With a bit of effort, the hatch pulls up through the water. ") +
					("Below is darkness, but you can just about make out a worryingly ") +
					("high level of water in the room. The ladder also seems to stop  ") +
					("above the hatch, so this is likely a one-way trip.\n\nPress D to ") +
					("jump down, or R to return.");
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.corridor_hatch;}
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.lower_storage_0;}
		
	}
	
	void lower_storage_0() {
		text.text = ("The water here is surprisingly deep,  much too deep to stand. ") +
					("This looks to be a storage space, filled with crates and cargo, each emblazoned ") +
					("with a black raven.\n\nYou doubt they’re waterproof.\n\nIn the darkness ") +
					("you can see a small, unlit lamp just above the water line, as well as a dark ") +
					("shape floating in the water further into the room.\n\nPress L to check the lamp ") +
					("or S to swim further into the room.");
		
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.lamp_0;}
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.body;}
		
	}
	
	void lamp_0() {
		text.text = ("This old lamp looks to have been smashed recently, and a film ") +
					("of oil has leaked into the water here.\n\nPress R to return. ") ;
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.lower_storage_0;}
		
		
	}
	
	void body() {
		text.text = ("The shape in the water is a body, apparently a sailor unlucky ") +
					("enough to be trapped here when the room flooded. \n\nIt could") +
					("be worth checking him over.\n\nIn the distance a faint light ") +
					("looks to be peeking through the roof.\n\nPress C to check the body," ) +
					("S to swim towards the light or R to return. ");	
					
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.body_key_0;}
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.exit_hatch_0;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.lower_storage_0;}
		

	}
	
	void exit_hatch_0() {
		text.text = ("At the far end of the room is a ladder, leading upto a hatch in the ") +
					("roof. The light you saw is peeking through the cracks.\n\nA cursory push ") +
					("indicates that the hatch is locked, and you can feel a small keyhole ") +
					("in the edge nearest the wall. <thief – Unfortunately it’s too dark to do any real work with.> ") +
					("Press R to return.");
		
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.body;}
				
	}
	
	void body_key_0() {
		text.text = ("The sailor’s pockets are empty, but around his neck is a key on a ") +
					("length of twine. Probably useful.\n\nPress R to return. ");

		if (Input.GetKeyDown (KeyCode.R))		{myState = States.lower_storage_1;}
		
	}
	
	void lower_storage_1() {
		text.text = ("From the center of the room, you can just about make out the ") +
					("sailor’s body, an extinguished lamp hanging above the water, and a ") +
					("telltale glow of light from the furthest end of the room.\n\nAnother  ") +
					("exit perhaps?\n\n Press B to check the body again, L to swim to the lamp ") +
					("or S to swim towards the light.");
		
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.body_key_1;}
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.lamp_1;}
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.exit_hatch_1;}
		
	}
	
	void body_key_1() {
		text.text = ("On closer inspection the sailor looks to have taken a blow to ") +
					("the head. Perhaps he was caught unawares by some falling cargo. ") +
					("Press R to return.  ") ;	

		if (Input.GetKeyDown (KeyCode.R))		{myState = States.lower_storage_1;}
		
	}
	
	void lamp_1() {
		text.text = ("The broken lamp still swings limply from the roof, though ") +
					("now noticeably closer to the water line. It seems this room ") +
					("isn’t quite finished flooding just yet. Press R to return. ") ;
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.lower_storage_1;}

	}
	
	void exit_hatch_1() {
		text.text = ("You swim towards the light and find a ladder against the wall. ") +
					("The light you saw seems to be coming through the cracks in a ") +
					("hatch in the roof here.\n\nThe hatch won’t budge, but you can  ") +
					("feel a keyhole. Perhaps your unlucky friend could help here?\n\n") +
					("Press U to unlock the hatch with the sailor’s key, or R to return.");
					
		if (Input.GetKeyDown (KeyCode.U))		{myState = States.galley_hatch;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.lower_storage_1;}
	}	
	
	void galley_hatch() {
		text.text = ("The hatch leads up to a small alcove off of a well lit room. ") +
					("Looking out you see what looks to be the ships galley, with two ") +
					("long tables set out, and wooden crockery sliding around the floor  ") +
					("as the ship rocks.\n\nTwo sailors bearing the sign of the raven stand  ") +
					("to the side, looking out of a porthole.\n\nOpposite them is a box ") +
					("which looks to be holding various weapons and equipment.\n\nPress C to continue.");
		
		if (myRace == Race.fighter) {			
			if (Input.GetKeyDown (KeyCode.C))		{myState = States.f_galley;}
		}else if (myRace == Race.wizard) {
			if (Input.GetKeyDown (KeyCode.C))		{myState = States.w_galley;}
		}else if (myRace == Race.thief) {
			if (Input.GetKeyDown (KeyCode.C))		{myState = States.t_galley;}
		}

	}
	
	void f_galley() {
		text.text = ("It’s clear here that their distraction is your advantage. You ") +
					("carefully make your way forward to within striking distance of ") +
					("the clueless pair.\n\nA heavy wooden bowl slides into your foot, ") +
					("and you quickly duck down to grab it. One good swing into the ") +
					("left sailor’s temple has him down for the count, and the second turns in shock.") +
					("Press C to continue.");
					
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.fight_scene;}
					
	}
	
	void fight_scene() {
		text.text = ("The second sailor doesn’t take long to recover, drawing a mace from the ") +
					("loop of his belt. You’ll need a weapon to even the odds. Throwing the bowl ") +
					("to distract him, you quickly check over his friends body for options.\n\n ") +
					("A heavy iron mace sits stuck through his belt at an odd angle, and a dagger is ") +
					("sheathed in the middle of his back.\n\nPress M for Mace or D for Dagger.");

		if (Input.GetKeyDown (KeyCode.M))		{myState = States.mace;}
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.knife;}
	}
	
	void mace() {
		text.text = ("You grab at the Mace and try to tug it free, but the angle of his ") +
					("limp body has it stuck fast. You quickly turn to find another option, ") +
					("only to see the head of your opponent’s mace swinging straight towards you./n/n  ") +
					("You are overcome by excruciating pain, and then remember nothing more than darkness.\n\n") +
					("Press B to go back and try again, or R to restart.");
					
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.fight_scene;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.start;}
		
	}
	void knife() {
		text.text = ("Knowing you have little time, you grab at the dagger, and it quickly ") +
					("slides from its sheath. \n\nYou have just enough time to roll away as  ") +
					("the sailor’s mace skims your forehead, and leap into a counterattack.  ") +
					("A swift stab into his leg interrupts him long enough for a good, hard punch ") +
					("across the jaw, sending him careening into the wall and out of consciousness. ") +
					("Press C to continue.");
					
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.galley_safe;}

	}
	
	void galley_safe() {
		text.text = ("As the last sailor falls to the ground, you are free to take a moment to ") +
					("catch your breath and find your belongings.\n\nOn the left is a box  ") +
					("of varying equipment, and at the opposite end of the room is a doorway.\n\n ") +
					("Press E to check the equipment box, or D to check the door. ");
					
		if (Input.GetKeyDown (KeyCode.E))		{myState = States.equipment;}
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.galley_door;}
		
	}
	
	void w_galley() {
		text.text = ("Despite being somewhat drained from your captivity and icy cold ") +
					("escape, the two of them look close enough together to deal with.\n\n ") +
					("It takes a serious effort to will the arcane energies into being in this state,  ") +
					("but you’re fairly certain that you have enough strength left for this spell.\n\n") +
					("Press S to cast Sleep.");
					
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.galley_safe;}

	}
	
	void equipment() {
		text.text = ("The box is full of assorted weapons and armour, presumably confiscated ") +
					("from various prisoners or enemy soldiers.\n\nYou take a moment to sort ") +
					("through and find your own equipment and change out of the wet rags you ") +
					("were so kindly given for this journey.\n\nPress R to return or D to check the door.") ;

		if (Input.GetKeyDown (KeyCode.R))		{myState = States.galley_safe;}
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.galley_door;}
		
	}
	
	void galley_door() {
		text.text = ("The wooden door does little to quiet the raging storm outside. ") +
					("Judging by the howl of the wind and the rain seeping under the frame, ") +
					("this door must lead to the deck of the ship.\n\nFreedom is close now.\n\n ") +
					("Press O to Open the door and head outside, E to inspect the equipment, or R to return.") ;
		
		if (Input.GetKeyDown (KeyCode.O))		{myState = States.deck_doorway;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.galley_safe;}
		if (Input.GetKeyDown (KeyCode.E))		{myState = States.equipment;}
		
	}
	
	void deck_doorway() {
		text.text = ("The wind outside is deafening, the rain falling in horizontal sheets. ") +
					("On the deck you can see shadows running frantically between boxes and ") +
					("the ship’s prow.\n\nJust ahead is a pile of boxes covered in netting. Looks  ") +	
					("like a good spot to hide and take stock.\n\nPress H to hide behind the boxes.");
	
		if (Input.GetKeyDown (KeyCode.H))		{myState = States.deck_boxes;}
	}
	
	void t_galley() {
		text.text = ("With the pair distracted, it should be simple to move undetected.  ") +
					("The sound of scraping crockery should mask your footsteps, and the tables ") +
					("could provide cover to slip over to the equipment box.\n\nPress  ") +
					("S to Sneak to your equipment. ");
					
		if (Input.GetKeyDown (KeyCode.S))		{myState = States.t_equipment;}
		
	}
	
	void t_equipment() {
		text.text = ("The box is full of assorted equipment, presumably from various ") +
					("prisoners the ship has taken. You quickly spot your own.\n\n ") +
					("Quietly slipping your leather armour over your head and donning your  ") +
					("cloak, you immediately feel more comfortable. Your daggers slip seamlessly ") +
					("into their sheathes as you turn to face the two unaware sailors.\n\n") +
					("Press A to attack or D to move towards the door.");
					
		if (Input.GetKeyDown (KeyCode.A))		{myState = States.t_fight_scene;}
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.t_galley_door;}

	}
	
	void t_fight_scene() {
		text.text = ("Sneaking up behind a pair as oblivious as these two is child’s play. ") +
					("Your daggers slip into their backs simultaneously, the pair dropping to ") +
					("the ground before they know what is happening.\n\nToo easy.\n\n") +
					("Press R to return to the centre of the room. ");
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.t_galley_safe;}
		
	}
	
	void t_galley_safe() {
		text.text = ("With the sailors dead, you are free to take a moment to ") +
					("catch your breath.\n\nAhead is the doorway that presumably leads ") +
					("to your freedom.\n\n") +
					("Press D to check the door. ");
					
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.t_galley_door;}

	}
	
	void t_galley_door() {
		text.text = ("The wooden door does little to quiet the raging storm outside. ") +
					("Judging by the howl of the wind and the rain seeping under the frame, ") +
					("this door must lead to the deck of the ship.\n\nFreedom is close now.\n\n ") +
					("Press O to Open the door and head outside.") ;
					
		if (Input.GetKeyDown (KeyCode.O))		{myState = States.deck_doorway;}
		
	}
	
	void deck_boxes() {
		text.text = ("From behind the boxes you have a better view of the situation ") +
					("on the deck. At the far end a catapult is firing flaming shells out into ") +
					("the night.\n\nSailors and soldiers are running between boxes to keep it loaded.\n\n") +
					("To your right, a lifeboat hangs limply over the side of the ship.") +
					("Press W to watch the guards, or B to run for the Boat.");
					
		if (Input.GetKeyDown (KeyCode.W))		{myState = States.deck_guard;}
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.boat_up_0;}

	}
	
	void deck_guard() {
		text.text = ("The guards are concentrated on carrying shells back and forth as ") +
					("quickly as possible, while avoiding the occasional response of arrows ") +
					("from somewhere out in the night.\n\nYou could probably time your run ") +
					("to the boat to avoid notice.\n\nPress R to return.") ;
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.deck_boxes;}	
						
	}
	
	void boat_up_0() {
		text.text = ("You dive into the lifeboat and quickly look around for the guards. You seem to ") +
					("have escaped notice.\n\nThe boat looks to be lowered using a pulley system, but ") +
					("a few tugs indicate that it’s jammed.\n\nYou could probably cut the rope to drop ") +
					("Into the water.\n\nPress C to cut the rope or R to return to the boxes.") ;

		if (Input.GetKeyDown (KeyCode.C))		{myState = States.boat_down;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.deck_boxes;}

	}
	//Upper Route//
	void upper_hatch() {
		text.text = ("Balanced on the ladder, you inspect the padlock. It fairly common, ") +
					("and is probably easy to pick with the right skills.\n\nAlternatively ") +
					("it’s possible that the right spell could pop it open easily enough.\n\n  ") +
					("Press R to return. <Thief – Press P to pick the lock><Wizard – Press U to cast Unlock>");
		
		if (myRace == Race.fighter) {
			if (Input.GetKeyDown (KeyCode.R))		{myState = States.corridor_hatch;}
		}else if (myRace == Race.thief) {
			if (Input.GetKeyDown (KeyCode.R))		{myState = States.corridor_hatch;}
			if (Input.GetKeyDown (KeyCode.P))		{myState = States.upper_hatch_open;}
		}else if (myRace == Race.wizard) {
			if (Input.GetKeyDown (KeyCode.R))		{myState = States.corridor_hatch;}
			if (Input.GetKeyDown (KeyCode.U))		{myState = States.upper_hatch_open;}
		}
	
	}
	
	void upper_hatch_open() {
		text.text = ("You open the hatch and pull yourself up into a storage area. Just ") +
					("in time it seems, as a huge crash echoes behind you, followed by the ") +
					("rush of water.\n\nSeems something gave way. Another lucky escape.\n\n ") +
					("Press L to look around.") ;
		
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.upper_storage_0;}

	}
	
	void upper_storage_0() {
		text.text = ("A couple of lanterns light this tightly packed storage room. Large boxes ") +
					("bearing the mark of the raven stand atop each other, well secured against ") +
					("the ship’s violent rocking.\n\nTwo small walkways have been left between the boxes, ") +
					("one leading to a small door, the other behind a particularly tight-set.")  +
					("pair of crates.\n\nPress D to check the door, or B to slip Behind the boxes.");
		
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.upper_door_0;}
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.behind_boxes_0;}
		
	}
	
	void upper_door_0() {
		text.text = ("The wooden door does little to quiet the raging storm outside. ") +
					("Judging by the howl of the wind and the rain seeping under the frame, ") +
					("this door must lead to the deck of the ship.\nPress O to head Outside, ") +
					("or R to return.");
					
		if (Input.GetKeyDown (KeyCode.O))		{myState = States.upper_deck_door;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.upper_storage_0;}

	}
	
	void behind_boxes_0() {
		text.text = ("It’s a tight fit, but behind the boxes you find a small cubbyhole. ") +
					("It seems someone has been hiding away here. An old pipe and dusty ") +
					("book sit atop a box, alongside a crowbar. To the left is another small ") +
					("box that looks to have been pried open.\n\nPress B to inspect the box") +
					("or R to return.");
					
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.treasure;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.upper_storage_0;}
		
	}
	
	void treasure() {
		text.text = ("The box is full of treasure! Gold coins and valuable gems, all bundled into ") +
					("small, wooden display boxes.  You quickly grab up all you can carry and ") +
					("squeeze back out of the cubbyhole. Press R to return.");
		
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.upper_storage_1;}

	}
	
	void upper_storage_1() {
		text.text = ("A couple of lanterns light this tightly packed storage room. Large boxes ") +
					("bearing the mark of the raven stand atop each other, well secured against ") +
					("the ship’s violent rocking.\n\nTwo small walkways have been left between the boxes, ") +
					("one leading to a small door, the other behind a particularly tight-set.")  +
					("pair of crates.\n\nPress D to check the door, or B to slip Behind the boxes.");
		
		if (Input.GetKeyDown (KeyCode.D))		{myState = States.upper_door_1;}
		if (Input.GetKeyDown (KeyCode.B))		{myState = States.behind_boxes_1;}
		
	}
	
	void behind_boxes_1() {
		text.text = ("It’s a tight fit, but you slip behind the boxes once more. ") +
					("The box of treasures remains open, and you wish someone had ") +
					("left a bag to carry them in.\n\nPress R to return.");

		if (Input.GetKeyDown (KeyCode.R))		{myState = States.upper_storage_1;}

	}
	
	void upper_door_1() {
		text.text = ("The wooden door does little to quiet the raging storm outside. ") +
					("Judging by the howl of the wind and the rain seeping under the frame, ") +
					("this door must lead to the deck of the ship.\nPress O to head Outside, ") +
					("or R to return.");
					
		if (Input.GetKeyDown (KeyCode.O))		{myState = States.upper_deck_door;}
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.upper_storage_1;}
		
	}
	
	void upper_deck_door() {
		text.text = ("Outside you find yourself fighting a howling gale. Lightning flashes ") +
					("across the sky, illuminating a large ship in the distance. As you watch, ") +
					("flaming shells fly forth from the vessel, and crash into the lower decks ") +
					("of the prison ship.\n\nPress L to look around.");
	
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.upper_deck;}	

	}
	
	void upper_deck() {
		text.text = ("To your immediate right stands a man dressed in fine leather. ") +
					("He is staring out through a spyglass, towards the attacking ship.\n\n") +
					("It’s a wonder he hasn’t noticed you.\n\nDown to your left, a lifeboat ") +
					("hangs from the deck below. You could probably jump straight down ") +
					("with a little luck.\n\nPress L to take a closer Look at the sailor, or J to Jump.");
		
		if (Input.GetKeyDown (KeyCode.L))		{myState = States.upper_guard;}
		if (Input.GetKeyDown (KeyCode.J))		{myState = States.boat_up_1;}
		
	}
	
	void upper_guard() {
		text.text = ("Judging by the quality of his clothes, this man must be a ranking ") +
					("officer of some description. He seems focused on the battle for now, ") +
					("but there’s no telling when he’ll notice your presence.\n\nPress ") +
					(" R to return.");
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.upper_deck;}

	}
	
	void boat_up_1() {
		text.text = ("You jump down heavily into the lifeboat and quickly look around. You seem to ") +
					("have escaped notice.\n\nThe boat itself looks to be lowered using a pulley system, but ") +
					("a few tugs indicate that it’s jammed.\n\nYou could probably cut the rope to drop ") +
					("Into the water.\n\nPress C to cut the rope.") ;
					
		if (Input.GetKeyDown (KeyCode.C))		{myState = States.boat_down;}
		
	}
	//End States
	void boat_down() {
		text.text = ("As soon as the rope breaks, the boat plummets to the water below. ") +
					("The hard landing stuns you, but the boat looks intact.\n\nYou’ve escaped your ") +
					("captors, now to escape the elements themselves.\n\nPress R to start rowing.");

		if (Input.GetKeyDown (KeyCode.R))		{myState = States.rowing;}

	}
	
	void rowing() {
		text.text = ("After a few minutes rowing, a flash of lightning illuminates the world ") +
					("around you.\n\nBehind you is ship you just escaped from, locked in battle with ") +
					("another vessel. Ahead is a rocky shoreline, and your only hope of freedom.\n\n") +
					("Press R to row harder.") ;
					
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.beach;}
		
	}
	
	void beach() {
		text.text = ("After what feels like hours of agonising rowing in freezing rain, ") +
					("the boat comes to an abrupt stop on a sandbar. You hop out onto ") +
					("the unstable sand, and run for the beach proper. Above you, the shadows ") +
					("of trees stretch up with menace.\n\nHopefully no one will be foolish ") +
					("enough to follow you under their dark boughs.\n\nPress E to enter the forest.");
		
		if (Input.GetKeyDown (KeyCode.E))		{myState = States.escape;}

	}
	
	void escape() {
		text.text = ("Running up the scree and into the damp undergrowth, the sound of  ") +
					("the storm dims somewhat.\n\nIn the darkness you have no idea where ") +
					("you have landed, only that your last hope is to keep running.\n\nGood Luck.\n\n ") +
					("Congratulations! Press R to restart.") ;
		
		if (Input.GetKeyDown (KeyCode.R))		{myState = States.start;}
		
	}
			
}