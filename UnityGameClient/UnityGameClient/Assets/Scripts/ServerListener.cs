using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServerListener : MonoBehaviour
{
    public FakeServer fakeServer;
    public Text slot1_availableText, slot2_availableText;
    public Text slot1_parkingTime, slot2_parkingTime;

    public GameObject slot1_parkButton, slot2_parkButton;
    public GameObject slot1_stopParkingButton, slot2_stopParkingButton;
    public float slot_1_timer, slot_2_timer;

    public void OnClickStartCounter(int slot)
    {
        switch (slot)
        {
            case 1:
                slot1_parkButton.GetComponent<Button>().interactable = false;
                slot1_availableText.text = "Not available";
                slot1_stopParkingButton.SetActive(true);
                Debug.Log("Slot 1 is now in use.");
                break;
            case 2:
                slot2_parkButton.GetComponent<Button>().interactable = false;
                slot2_availableText.text = "Not available";
                slot2_stopParkingButton.SetActive(true);
                Debug.Log("Slot 2 is now in use.");
                break;

        }

    }

    public void OnClickStopParking(int slot)
    {
        switch (slot)
        {
            case 1:
                fakeServer.slot_1_available = true;
                slot1_parkButton.GetComponent<Button>().interactable = true;
                slot1_availableText.text = "Available";
                slot1_stopParkingButton.SetActive(false);
                break;
            case 2:
                fakeServer.slot_2_available = true;
                slot2_availableText.text = "Available";
                slot2_parkButton.GetComponent<Button>().interactable = true;
                slot2_stopParkingButton.SetActive(false);
                break;
        }
    }

    private void Update()
    {
        if(!fakeServer.slot_1_available)
        {
            slot_1_timer += Time.deltaTime;
            string min = Mathf.Floor(slot_1_timer/60).ToString("00");
            string sec = (slot_1_timer % 60).ToString("00");
            slot1_parkingTime.text = string.Format(fakeServer.car1.GetComponent<Text>().text + " has been parking for " + "{0}:{1}", min, sec);
            
        }

        if (!fakeServer.slot_2_available)
        {
            slot_2_timer += Time.deltaTime;
            string min = Mathf.Floor(slot_2_timer / 60).ToString("00");
            string sec = (slot_2_timer % 60).ToString("00");
            slot1_parkingTime.text = string.Format(fakeServer.car2.GetComponent<Text>().text + " has been parking for " + "{0}:{1}", min, sec);
        }
    }
}
