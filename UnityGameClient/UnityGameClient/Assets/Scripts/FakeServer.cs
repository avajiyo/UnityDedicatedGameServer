using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FakeServer : MonoBehaviour
{
    public ServerListener serverListener;
    public GameObject car1, car2;

    string plate1, plate2;

    public bool slot_1_available = true;
    public bool slot_2_available = true;

    public void SendPlateInformation_1()
    {
        if (car1.GetComponent<Text>().text != "" && car1.GetComponent<Text>().text.Length == 6)
        {
            Debug.Log("License plate recognized: " + car1.GetComponent<Text>().text);
            plate1 = car1.GetComponent<Text>().text;
            car1.GetComponent<Text>().text = null;
            slot_1_available = false;
            serverListener.OnClickStartCounter(1);
        }
        else
        {
            Debug.Log("Cannot park: check the license plate format!");
        }
    }

    public void SendPlateInformation_2()
    {
        if (car2.GetComponent<Text>().text != "" && car2.GetComponent<Text>().text.Length == 6)
        {
            Debug.Log("License plate recognized " + car2.GetComponent<Text>().text);
            plate2 = car2.GetComponent<Text>().text;
            car2.GetComponent<Text>().text = null;
            slot_2_available = false;
            serverListener.OnClickStartCounter(2);
        }
        else
        {
            Debug.Log("Cannot park: check the license plate format!");
        }

    }

}
