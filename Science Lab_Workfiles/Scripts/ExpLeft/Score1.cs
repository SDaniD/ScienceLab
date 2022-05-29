using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public Text txt;
    int score2 = 0;
  
    void Update()
    {
        txt.text = PlayerPrefs.GetInt("score2").ToString();
    }
    public void Clean()
    {
        PlayerPrefs.SetInt("but1_2", 0);
        PlayerPrefs.SetInt("but2_2", 0);
        PlayerPrefs.SetInt("but3_2", 0);
        PlayerPrefs.SetInt("score2", 3);
    }
    public void but1_2(){
      
        if (PlayerPrefs.GetInt("but1_2") != 1)
        {
            print(PlayerPrefs.GetInt("but1_2"));
            PlayerPrefs.SetInt("but1_2", 1);
            score2 = PlayerPrefs.GetInt("score2");
            score2--;
            PlayerPrefs.SetInt("score2", score2);
            print(PlayerPrefs.GetInt("but1_2"));

               print(score2);
        }
        print(PlayerPrefs.GetInt("but1_2"));
        print(PlayerPrefs.GetInt("score2"));
        txt.text = PlayerPrefs.GetInt("score2").ToString();
    }
    public void but2_2()
    {
        if (PlayerPrefs.GetInt("but2_2") != 1)
        {
            print(PlayerPrefs.GetInt("but2_2"));
            PlayerPrefs.SetInt("but2_2", 1);
            score2 = PlayerPrefs.GetInt("score2");
            score2--;
            PlayerPrefs.SetInt("score2", score2);
            print(PlayerPrefs.GetInt("but2_2"));
               print(score2);
        }
        print(PlayerPrefs.GetInt("but2_2"));
        print(PlayerPrefs.GetInt("score2"));
        txt.text = PlayerPrefs.GetInt("score2").ToString();
    }
    public void but3_2()
    {
        if (PlayerPrefs.GetInt("but3_2") != 1)
        {
            print(PlayerPrefs.GetInt("but3_2"));
            PlayerPrefs.SetInt("but3_2", 1);
            score2 = PlayerPrefs.GetInt("score2");
            score2--;
            PlayerPrefs.SetInt("score2", score2);
            print(PlayerPrefs.GetInt("but3_2"));
            print(score2);
        }
        print(PlayerPrefs.GetInt("but3_2"));
        print(PlayerPrefs.GetInt("score2"));
        txt.text = PlayerPrefs.GetInt("score2").ToString();
    }
}
