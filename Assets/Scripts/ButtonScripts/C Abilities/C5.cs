using UnityEngine;
using System.Collections;

public class C5 : MonoBehaviour {

	public Player player;
	
	public UIButton button;
	
	
	void OnClick(){
		
		if(player.TurnPhases == 3){
				
			player.stanceChosen = 5;
			
			player.stanceChanged = true;
			player.TurnPhases = 0;
			
				//Delay
				//player.gameTimer = Time.time + 3;
				
			
		}
		
	}
	
	void OnHover(){
			if(player.TurnPhases == 3)
				player.lastAbilityChosen = 15;
	}
	
	
	void Update(){
		
		if(player.TurnPhases == 3){
			button.isEnabled = true;
		
			button.defaultColor = Color.white;
		}
		else{
			button.isEnabled = false;
			button.defaultColor = Color.clear;
		}
		
	}
}
