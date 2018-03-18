using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartINSTRUCTIOON : MonoBehaviour {

    public GameObject StartInsr;
    public GameObject MenuInstru;

    public void SetActiveCan(){
        StartInsr.SetActive (true);
        MenuInstru.SetActive (false);
    
    }

    public void DisActiveCan(){

        StartInsr.SetActive (false);
        MenuInstru.SetActive (true);
    }

}
