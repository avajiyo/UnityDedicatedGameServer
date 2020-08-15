using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGoogleSheetData : MonoBehaviour
{
    private void Start()
    {
        UsageTime usageTime = (UsageTime)Resources.Load("Google/UsageDataAsset", typeof(UsageTime));
        if(usageTime == null)
        {
            Debug.Log("Error: File null or missing");
        }
        for(int i = 0; i < usageTime.dataArray.Length; i++)
        {
            Debug.LogFormat("Key: {0}, Name: {1}, Usage Time (Total): {2}", usageTime.dataArray[i].Key, usageTime.dataArray[i].Name, usageTime.dataArray[i].Usagetime_Total);
        }
    }

}
