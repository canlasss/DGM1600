using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoryScirpt : MonoBehaviour {

    public Text textObject;

    public enum States { start, forest, forest_r, cave, shore_0, shore_w, shore_r, shore_fixed };
    public States myState;

    public bool lockpick = false;

    public bool rope = false;
    public bool wood = false;

    void Start() {
        myState = States.start;


    }

    void Update() {
        if (myState == States.start) {
            State_start();
        } else if (myState == States.forest) {
            State_forest();
        } else if (myState == States.cave) {
            State_cave();
        } else if (myState == States.shore_0) {
            State_shore();
        }

    }

    void State_start() {
        textObject.text = "You are on a small sesert island. " +
            "\nThere is a Forest with trees." +
            "\nThere is a Cave." +
            "\n\nPress F to go to Forest. Press C to go to Cave";

        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.forest;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.cave;
        }
    }

    void State_forest() {
        if (rope == true) {
            textObject.text = "You are in a forest with palm trees." +
                "\nThe palm trees have long whispy palm fronds, good for making rope." +
                "\n\nPress S to go back to start. Press C to go to Cave.";

        } else }
        textObject.text = "You are in a forest with palm tress." +
                "\nThe palm trees have long whispy palm fronds, good for making rope." +
                "\n\nPress R to make Rope." +
                "\n\nPress S to go back to Start. Press C to go to cave." ;
        }
        if (Input.GetKeyDown (KeyCode.R)) {
            rope = true;
        } else if (Input.GetKeyDown (KeyCode))

    void State_cave() {
        textObject.text = "You are in a cave." +
        "\nThere is the Shoreline nearby." +
        "\nIt is damp and drippy." +
        "\nThere are some wood planks nearby." +
        "\n\nPress W to take wood" +
        "\n\nPress F to go to Forest. Press S to go to Shore.";
        if (Input.GetKeyDown(KeyCode.W)) {
            wood = true;
        }
        }

    }
