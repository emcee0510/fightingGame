using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
   
    public static int P1Health;
    public static int P2Health;
    public static String PlayerOne;
    public static String PlayerTwo;
    public GameObject p1HP;
    public GameObject p2HP;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject InputOne;
    public GameObject InputTwo;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        p1HP.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = P1Health + "";
        p2HP.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = P2Health + "";
        Player1.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerOne + "";
        Player2.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerTwo + "";
    }

    void FixedUpdate(){

       
    }

    public void Inputs()
    {
       PlayerOne = InputOne.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text;
       PlayerTwo = InputTwo.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text;
        SceneManager.LoadScene(1);

    }

    public void SetHealth50()
    {
        P1Health = 50;
        P2Health = 50;
    }

    public void SetHealth100()
    {
        P1Health = 100;
        P2Health = 100;     
    }

}
