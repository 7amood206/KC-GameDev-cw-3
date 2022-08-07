using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {

        string heroName = "hero";
        int heroPower = 20;
        string villianName = "villian";
        int villianPower = 10;

        if (heroPower > villianPower)
        {
            print("hero is stronger");
        }
        else if (heroPower == villianPower)
        {
            print("they are tied");
        }
        else 
        {
            print("villian is stronger");
        }

        setSpeed(2.5f);
        compareSpeed(3.5f , 2.5f);
        }

    float playerSpeed = 3.5f;

    void setSpeed(float speed){
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }

    void compareSpeed(float oldSpeed, float newSpeed){
        if (oldSpeed > newSpeed){
            print(oldSpeed);
        }
        else if (oldSpeed == newSpeed){
            print(oldSpeed + "," + newSpeed);
        }
        else {
            print(newSpeed);
        }
    }

}

