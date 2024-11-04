using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health =0;

    public static int playerCount=0;


    public void InitializePlayer(string name, int initialHealth){
        playerName=name;
        health=initialHealth;
        playerCount++;

    }

    public void Heal(int amount){
        health=health+amount;
        Debug.Log("Player "+playerName + " health is : " +health);

    }

    public void Heal(bool fullRestore){
        if (fullRestore==true){
           health=100; 
           Debug.Log("Player "+playerName + " health is full restore to : " +health);
        }
    }

     public static void ShowPlayerCount(){
        Debug.Log("Total Players counts are: " + playerCount);
     }
    
}
