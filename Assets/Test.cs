using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int fuel = 100;
    public float lapProgress;
    public float reqLapProgress = 200f;
    public int laps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check how much fuel I have
        //If I still have fuel, increase progression and decrease fuel
        if(fuel > 0)
        {
            //increase progression
            lapProgress += 5;
            //decrease fuel
            fuel--;
        }
        else
        {
            //Out of fuel
            Debug.Log("Bad Luck, we're out of fuel!");
        }
        //if I have enough progression, count a lap
        if(lapProgress >= reqLapProgress)
        {
            //reset progression
            lapProgress = 0;
            //increase laps
            laps++;
        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Current Laps: " + laps);
    }
}
