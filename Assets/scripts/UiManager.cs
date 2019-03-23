using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

	int score, highscore;
	public Text textScore, textHighscore; 
	bool GameOver;
	public Button []btn;


    /// 
    /// KSEKINIMA TOU PAIXNIDIOU, ANAKTISI HIGHSCORE, KSEKINIMA NEOU SCORE APO 0
    ///
	void Start () {
		GameOver = false;
		score = 0;
		InvokeRepeating ("UpdateScore",1f,0.7f);
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        textHighscore.text = "Highscore:" + highscore;
	}

    /// 
    /// KALEITAI KATHE 1 FRAME
    ///
    void Update () {
		if(textScore!=null)
		textScore.text = "Score:"+score;
	}

    /// 
    /// ANANEWSH TOU SCORE OSO O PAIKTHS DEN XANEI
    ///
    void UpdateScore(){
		if (!GameOver) {
			
			score++;
		}
	}

    /// 
    /// TELOS TOU PAIXNIDIOU, APOTHIKEUSH HIGHSCORE (EAN EINAI TO HIGHEST), EMFANISI KOUMPIWN
    ///
    public void gameOver(){	
		GameOver = true;
		foreach(Button but in btn){
			but.gameObject.SetActive (true);
		}

        if (score>highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
        }
	}

    /// 
    /// KALEI THN SCENE 1 POU EINAI TO PAIXNIDI
    ///
    public void Play(){
		SceneManager.LoadScene(1);
	}

    /// 
    /// PAUSH TOU PAIXNIDIOU
    ///
    public void pause(){
		if (Time.timeScale == 1)
			Time.timeScale = 0;
		else if (Time.timeScale ==0)
			Time.timeScale = 1;
	}

    /// 
    /// KALEI TH SCENE 0 POU EINAI TO MENU
    ///
    public void MENU(){
		SceneManager.LoadScene(0);
	}

    /// 
    /// KLISIMO PROGRAMATOS
    ///
    public void EXIT(){
		Application.Quit();

	}
}
