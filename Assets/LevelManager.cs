using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public enum LevelState { Level0, Level1, Level2 };
    public LevelState myLevelState;

    public Light worldLight;
    public Light fireplaceLight;
    float timer = 0.0f;

    public AudioSource musicPlayer;
    public AudioClip musicOne;

    public bool torchPickup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log("timer is value " + timer);
        
        if(myLevelState == LevelState.Level0)
        {
            //'it is level 0
            Debug.Log("it's level 0");
            //nothing to do, we're already ready

            if(timer > 7.0f)
            {
                myLevelState = LevelState.Level1;
                musicPlayer.clip = musicOne;
                musicPlayer.Play();
                worldLight.intensity = 0.0f;
            }
        }

        if(myLevelState == LevelState.Level1)
        {
            //it is level 2
            Debug.Log("were in level 2");
            // the lights off

            //loops for things that need to happen over and over?
            fireplaceLight.intensity = Random.Range(0.0f, 10.0f);


            if(torchPickup == true) //if torchPickup == true;
            {
                myLevelState = LevelState.Level2;
                //transition to level 2
                //set anything that needs setting, eg music or light settings
            }
 
        }

        if(myLevelState == LevelState.Level2)
        {
            fireplaceLight.color = Color.blue;


            //go back to level 1 because they dropped the torch
            if(torchPickup == false)
            {
                myLevelState = LevelState.Level1;

            }

            //move onto level 3

        }

    }
}
