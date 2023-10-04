using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite DG;
    public Sprite LG;
    public string chr;
    
    void Update() {
        try{
        if (Input.GetKey(chr))
        {
            sprite.sprite = LG;
        }
        else {
            sprite.sprite = DG;
        }
        }catch(System.Exception e){
            Debug.Log("errororororor: " +e);
        }
    }
}
