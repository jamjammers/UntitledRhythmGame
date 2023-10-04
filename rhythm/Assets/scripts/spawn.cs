using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public controlSC control;
    public GameObject spawned;
    public Transform trans;
    public string chr;
    public float bts = 0;
    public string halp = "asdfjkl";
    public int spot = 0;
    // Start is called before the first frame update
    void Start()
    {
        //import control script (variable hub)
        control = GameObject.FindGameObjectWithTag("Control").GetComponent<controlSC>();
    }

    // Update is called once per frame
    void Update()
    {
        //keep track of num of beats
        bts += 30 * Time.deltaTime;

        //checks if x bts have elapsed
        if (bts >= 57/4.5/4&&control.nya.isPlaying)
        {
            //if in chart, then makes a clone
            if (control.chart[spot].IndexOf(chr) > -1) { 
            Instantiate(spawned, new Vector3(trans.position.x, trans.position.y, trans.position.z), transform.rotation);
        }
            //resets bts and increases spot (which location it is at)
            bts = 0;
            spot++;
        }
    }
}
