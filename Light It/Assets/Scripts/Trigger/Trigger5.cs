using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Trigger5: MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject fakelamb;
    public GameObject reallamb;
    public GameObject ActionText;
    public GameObject ExtraCross;
    public GameObject ActionDisplay;
    public GameObject Text;
    public GameObject Countdown;
    public GameObject Light;
    public GameObject Torch;
    public GameObject buton;
    
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
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
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
                Countdown.SetActive(false);
                ExtraCross.SetActive(false);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                Light.SetActive(true);
                Torch.SetActive(true);
                buton.SetActive(true);
                StartCoroutine(TakeToMenu());
                
            }
            

        }

    }
    private void OnTriggerExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator TakeToMenu()
    {
        Text.GetComponent<Text>().text = "You managed to get rid of the zombies by placing the lights.";
        yield return new WaitForSeconds(5);
        Text.GetComponent<Text>().text = "";
        
        
    }
}
