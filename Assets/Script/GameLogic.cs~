using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	public Text scoreText;
	public static int  score ;
    public static int highscore;

	// Use this for initialization
	void Start(){
		score = 0;
        //highscore = 0;
        highscore = PlayerPrefs.GetInt ("highscore", highscore);
       scoreText.text ="Score : " + highscore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (score > highscore){
        highscore = score;
            scoreText.text = "Score : " + score;

     PlayerPrefs.SetInt ("highscore", highscore);
		
	}
    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt ("highscore", highscore);
        PlayerPrefs.Save();
    }

}

