using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Trigger1: MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject fakelamb;
    public GameObject reallamb;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject ActionDisplay;
    public GameObject fakelamb2;
    public GameObject trigger;
    public GameObject TextBox;
    
    public void Start()
    {
        fakelamb.SetActive(true);
    }
    
    void OnTriggerEnter()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        if (fakelamb.activeInHierarchy == true)
        {
            ExtraCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Light It";
            ActionText.SetActive(true);
            ActionDisplay.SetActive(true);
            
        }

    }
    public void Update()
    {
        if (fakelamb.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                reallamb.SetActive(true);
                fakelamb.SetActive(false);
                fakelamb2.SetActive(true);
                trigger.SetActive(true);
                ActionDisplay.SetActive(false);
                ExtraCross.SetActive(false);
                ActionText.SetActive(false);
                StartCoroutine(Hint());

            }
            
        }

    }
    
    private void OnTriggerExit()
    {
       
        ActionDisplay.SetActive(false);
        ExtraCross.SetActive(false);
        ActionText.SetActive(false);
       
    }
    IEnumerator Hint()
    {
        TextBox.GetComponent<Text>().text = "Check next to armchair for 2nd light";
        yield return new WaitForSeconds(5);
        TextBox.GetComponent<Text>().text = "";


    }
}
