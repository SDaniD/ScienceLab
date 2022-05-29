using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;
    int score = 0;
  
    void Update()
    {
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void Clean()
    {
        PlayerPrefs.SetInt("but1", 0);
        PlayerPrefs.SetInt("but2", 0);
        PlayerPrefs.SetInt("but3", 0);
        PlayerPrefs.SetInt("but4", 0);
        PlayerPrefs.SetInt("but5", 0);
        PlayerPrefs.SetInt("but6", 0);
        PlayerPrefs.SetInt("but7", 0);
        PlayerPrefs.SetInt("but8", 0);
        PlayerPrefs.SetInt("but9", 0);
        PlayerPrefs.SetInt("but10", 0);
        PlayerPrefs.SetInt("score", 10);
    }
    public void but1(){
      
        if (PlayerPrefs.GetInt("but1") != 1)
        {
            print(PlayerPrefs.GetInt("but1"));
            PlayerPrefs.SetInt("but1", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but1"));

               print(score);
        }
        print(PlayerPrefs.GetInt("but1"));
        print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but2()
    {
        if (PlayerPrefs.GetInt("but2") != 1)
        {
            print(PlayerPrefs.GetInt("but2"));
            PlayerPrefs.SetInt("but2", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but2"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but2")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but3()
    {
      
        if (PlayerPrefs.GetInt("but3") !=1)
        {
            print(PlayerPrefs.GetInt("but3"));
            PlayerPrefs.SetInt("but3", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but3"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but3")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();

    }
    public void but4()
    {
        if (PlayerPrefs.GetInt("but4") != 1)
        {
            print(PlayerPrefs.GetInt("but4"));
            PlayerPrefs.SetInt("but4", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but4"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but4")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but5()
    {
        if (PlayerPrefs.GetInt("but5") != 1)
        {
            print(PlayerPrefs.GetInt("but5"));
            PlayerPrefs.SetInt("but5", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but5"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but5")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but6()
    {
        if (PlayerPrefs.GetInt("but6") != 1)
        {
            print(PlayerPrefs.GetInt("but6"));
            PlayerPrefs.SetInt("but6", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but6"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but6")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but7()
    {
        if (PlayerPrefs.GetInt("but7") != 1)
        {
            print(PlayerPrefs.GetInt("but7"));
            PlayerPrefs.SetInt("but7", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but7"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but7")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but8()
    {
        if (PlayerPrefs.GetInt("but8") != 1)
        {
            print(PlayerPrefs.GetInt("but8"));
            PlayerPrefs.SetInt("but8", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but8"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but8")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but9()
    {
        if (PlayerPrefs.GetInt("but9") != 1)
        {
            print(PlayerPrefs.GetInt("but9"));
            PlayerPrefs.SetInt("but9", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but9"));
               print(score);
        }
        print(PlayerPrefs.GetInt("but9")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }
    public void but10()
    {
        if (PlayerPrefs.GetInt("but10") != 1)
        {
            print(PlayerPrefs.GetInt("but10"));
            PlayerPrefs.SetInt("but10", 1);
            score = PlayerPrefs.GetInt("score");
            score--;
            PlayerPrefs.SetInt("score", score);
            print(PlayerPrefs.GetInt("but10"));
              print(score);
        }
        print(PlayerPrefs.GetInt("but10")); print(PlayerPrefs.GetInt("score"));
        txt.text = PlayerPrefs.GetInt("score").ToString();
    }

}
