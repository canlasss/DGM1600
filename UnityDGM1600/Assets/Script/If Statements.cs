using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float soupTemperature = 90.0f;
    float hotLimitTemperature = 75.0f;
    float coldLimitTemperature = 45.0f;

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        soupTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest ()
    {
        //If the soup is at a very hot temperature than it's so supposed to be...
        if(soupTemperature > hotLimitTemperature)
        {
            // ... you can do.
            print("Soup is very hot to eat.");

        }
        //If the soup isn't hot as a regular temperature for soups and it's not so good... 
        else if(soupTemperature <coldLimitTemperature)
        {
            // ... you can also do.
            print("Soup is too cold to eat");
        }
        // If none of the choices won't work...
        else
        {
            // ... then do this.
            print("Soup is ready to eat");

        }
	}
}

