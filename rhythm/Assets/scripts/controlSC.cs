using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class controlSC : MonoBehaviour
{
    public Text textScore;
    public Text grade;
    public int score;
    public AudioSource click;
    public AudioSource nya;
    float opacity = 1f;
    float clock;
    bool played = false;
    public string[] chart = { "s", "d", "j", "k", "s", "d", "j", "k", "s", "d", "j", "k" };//this is an example, not actually used in the code
    // Start is called before the first frame update
    void Start()
    {
        grade.text = "hello world";
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        if (!played && clock >= 100/114)
        {
            nya.Play();
            //lesss
            Debug.Log("executed");
            played = true;
        }
        //decreases opacity, and displays it
        opacity -= Time.deltaTime*2f;
        grade.color = new Color(grade.color.r, grade.color.g, grade.color.b, opacity);
        if(!nya.isPlaying){
            
        }
    }
    //increase points by amt, also fixes the score to show it
    public void plusPts(int amt, bool pos) {
        if(pos){
            score += amt;
        }else{
            score-=amt;
        }
        textScore.text = "score: "+score.ToString();
    }
    //changes grade, to "text" and rgb( r g b), resets opacity
    public void gradeAlt(string input, float r,float g,float b) {
        grade.text = input;
        opacity = 1f;
        grade.color = new Color(r / 255f, g / 255f, b / 255f, opacity);
    }
}
