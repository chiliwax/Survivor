using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour
{
    public void EntryToLeft()
    {
        SceneManager.LoadScene("EntryLeft");
        inventory.scene = "EntryLeft";
    }
    public void EntryToCoridorLeft_1()
    {
        SceneManager.LoadScene("coridor-left-1");
        inventory.scene = "coridor-left-1";
    }

    public void EntryToCoridorLeft_2()
    {
        SceneManager.LoadScene("coridor-left-2");
        inventory.scene = "coridor-left-2";
    }

public void EntryToCoridorRight_1()
    {
        SceneManager.LoadScene("coridor-right-1");
        inventory.scene = "coridor-right-1";
    }

    public void EntryToCoridorRight_2()
    {
        SceneManager.LoadScene("coridor-right-2");
        inventory.scene = "coridor-right-2";
    }

    public void Etage1_fromLeft()
    {
        SceneManager.LoadScene("Etage1_from_left");
        inventory.scene = "Etage1_from_left";
    }
    public void Etage1_fromRight()
    {
        SceneManager.LoadScene("Etage1_from_right");
        inventory.scene = "Etage1_from_right";
    }
    public void Room_corridor1()
    {
        SceneManager.LoadScene("Room_corridor1");
        inventory.scene = "Room_corridor1";
    }
    public void Room_corridor2()
    {
        SceneManager.LoadScene("Room_corridor2");
        inventory.scene = "Room_corridor2";
    }
    public void Room_corridor3()
    {
        SceneManager.LoadScene("Room_corridor3");
        inventory.scene = "Room_corridor3";
    }
    public void Etage1_center()
    {
        SceneManager.LoadScene("Etage1_Center");
        inventory.scene = "Etage1_Center";
    }
    public void EntryToRight()
    {
        SceneManager.LoadScene("EntryRight");
        inventory.scene = "EntryRight";
    }
    public void EntryManor()
    {
        SceneManager.LoadScene("Manor_entrance");
        inventory.scene = "EntryRight";
    }

        public void Room1()
    {
        SceneManager.LoadScene("Room1");
        inventory.scene = "Room1";
    }

            public void Room2()
    {
        SceneManager.LoadScene("Room2");
        inventory.scene = "Room2";
    }

        public void Room3()
    {
        SceneManager.LoadScene("Room3");
        inventory.scene = "Room3";
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Shadow");
            Debug.Log("swap");
        }
    }
}
