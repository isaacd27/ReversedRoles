using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public GameObject Parent;
    public int maxhp;
    int hp;
    public Slider bar;
    Enemy main;
    // Start is called before the first frame update
    void Start()
    {
        maxhp = Parent.GetComponent<Enemy>().HP;
        main = Parent.GetComponent<Enemy>();
        hp = maxhp;
        bar.maxValue = maxhp;
        bar.gameObject.SetActive(false);
    }

    public void updatehp(int change)
    {
        hp += change;
    }
    // Update is called once per frame
    void Update()
    {
        bar.value = hp;

        if (Input.mousePosition.x >= Parent.transform.position.x + Parent.GetComponent<SpriteRenderer>().bounds.size.x / 2 && Input.mousePosition.x <= Parent.transform.position.x - Parent.GetComponent<SpriteRenderer>().bounds.size.x / 2)//not sure if <= or >=, but the bounds is the width of the sprite, and the position is at the center.
        {
            if (Input.mousePosition.y >= Parent.transform.position.y + Parent.GetComponent<SpriteRenderer>().bounds.size.y / 2 && Input.mousePosition.y <= Parent.transform.position.y - Parent.GetComponent<SpriteRenderer>().bounds.size.y / 2)
            {
                bar.gameObject.SetActive(true);
                //if it doesn't work try reversing the < and >

            }
            else
            {
                bar.gameObject.SetActive(false);
            }
        }
        //test

       /* if (Input.mousePosition == Parent.transform.position) //change to detect within the bounds of the sprite
        {
            bar.gameObject.SetActive(true);
            //same if statement can be used to show movement and attacks, if it's your thing.
        }
        else
        { bar.gameObject.SetActive(false);
        } */
    }
}
