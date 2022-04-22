using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    int level = 1;

    float curXPProgress = 0f;
    float reqXP = 100f;

    float XP = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(XP);
        }
    }

    public void GainProgress(float progress)
    {
        curXPProgress += progress;
        Debug.Log("XP gained: " + progress);
        Debug.Log("Current XP is: " + curXPProgress);
        CheckProgress(curXPProgress);
    }

    public void CheckProgress(float progress)
    {
        if(progress >= reqXP)
        {
            //Completed a lap!
            LevelUp();
            Debug.Log("Keep going!");
        }
    }

    public void LevelUp()
    {
        //update our laps
        level += 1; //laps++;
        //reset our current lap progress to 0
        curXPProgress = 0f;
        //either, increase our required lap progress, or change our speed
        reqXP *= 1.15f;
        Debug.Log("Level up!");
        Debug.Log("You are now level " + level);
    }
}
