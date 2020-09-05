/** Sam Carpenter
* Assignment 1
* used to make sure the player wins and loses, mostly based off my previous score manager script but with tweaks to better fit the format of the game.
* also bundles in the trigger collision for convienence
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
	public Text wintext;
	public Text scorenum;
	public int gameo = 0;
	public int scorethresh = 5;
	public int score = 0;
		
    // Update is called once per frame
     void Update()
    {
		scorenum.text = score.ToString();
		
		if(gameo == 0){
			if(score >= scorethresh){
				gameo = 1;
			} else if (transform.position.y > 80 || transform.position.y < -50){
				gameo = -1;
			}
		}else if (gameo == 1){
			wintext.text = "You Win!\nPress R to Try Again";
		} else{
			wintext.text = "You Lose!\nPress R to Try Again";
		}
		
		if(Input.GetKeyDown(KeyCode.R) && gameo != 0){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
    }
	
	private void OnTriggerEnter(Collider other){
		if(other.CompareTag("Finish") && gameo == 0 && !other.GetComponent<Once>().triggered){
			score++;
			other.GetComponent<Once>().triggered = true;
		}
	}
}