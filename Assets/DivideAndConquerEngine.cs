using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquerEngine : MonoBehaviour {
   public int Guess;
    public int Max;
    public int Min;
    
    // Use this for initialization
    void Start () {
        Debug.Log("Welcome to divide and conquer game");
        Debug.Log("Pick a number in your mind. Let see How good you are hiding numbers");
        //sin estilo
        Debug.Log("The minim number that you can pick is" + Min);
        //con estilo
        Debug.Log(string.Format("The highest number that you can pick is {0}",Max));
        Debug.Log("is te number > or < that" + Guess + "?");
        Debug.Log("Up arrow ==>,Down arrow==<,Enter == ");

    }

    // Update is called once per frame
    void Update() {
        Engine();
    }
    void Engine() {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Min = Guess;
            Algorithm();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Max = Guess;
            Algorithm();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I win");
        }
            

            void Algorithm(){

                Guess = (Max + Min) / 2;
                Debug.Log("Mayor > o menor que:");
            }
        }
    }
