using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clone : MonoBehaviour
{
    public AudioSource click;
    public controlSC control;
    public spawn origin;
    //is touching (top/middle/bottom)
    public bool isT = false;
    public bool isM = false;
    public bool isB = false;
    //identifies which Pre-Fab its on
    public string chr;

    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.FindGameObjectWithTag("Control").GetComponent<controlSC>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.up * 15 * 30/57*2 * Time.deltaTime);
        //release on anddd
        if (transform.position.y > 7.7) {
            control.plusPts(10,false);
            control.gradeAlt("miss...", 153f, 153f, 153f);
            Destroy(gameObject);
         }
        if (Input.GetKeyDown(chr)) {
            if (isT && isB)
            {
                click.Play();
                control.plusPts(10,true);
                control.gradeAlt("Perfect", 204f, 204f, 255f);
                Destroy(gameObject);
            }
            else if (isM)
            {
                click.Play();
                control.plusPts(5,true);
                control.gradeAlt("Nice", 102f, 204f, 255f);
                Destroy(gameObject);
            }
            else if (isT || isB)
            {
                click.Play();
                control.plusPts(2,false);
                control.gradeAlt("bad", 153f, 255f, 153f);
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Up-Check")
        {
            isT = true;
        }
        else if (col.gameObject.name == "Down-Check")
        {
            isB = true;
        }
        else if (col.gameObject.name == "Mid-Check")
        {
            isM = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Up-Check")
        {
            isT = false;
        }
        else if (col.gameObject.name == "Down-Check")
        {
            isB = false;
        }
        else if (col.gameObject.name == "Mid-Check")
        {
            isM = false;
        }
    }
}
