using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(UsageTime))]
public class UsageTimeEditor : BaseGoogleEditor<UsageTime>
{	    
    public override bool Load()
    {        
        UsageTime targetData = target as UsageTime;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<UsageTimeData>(targetData.WorksheetName) ?? db.CreateTable<UsageTimeData>(targetData.WorksheetName);
        
        List<UsageTimeData> myDataList = new List<UsageTimeData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            UsageTimeData data = new UsageTimeData();
            
            data = Cloner.DeepCopy<UsageTimeData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
