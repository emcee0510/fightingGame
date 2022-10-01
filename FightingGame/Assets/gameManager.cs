using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public float time;
    public GameObject GoTime;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject InputOne;
    public GameObject InputTwo;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){

       GoTime.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = time.ToString("0") + "";
    }

    void FixedUpdate(){
        
        time -= Time.deltaTime;
    }

    public void InputNames()
    {
        Player1.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = InputOne.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text + "";
        Player2.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = InputTwo.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text + "";

    }
}
