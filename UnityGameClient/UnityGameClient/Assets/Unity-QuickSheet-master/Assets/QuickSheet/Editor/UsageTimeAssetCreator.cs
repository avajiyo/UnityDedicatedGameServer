using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/UsageTime")]
    public static void CreateUsageTimeAssetFile()
    {
        UsageTime asset = CustomAssetUtility.CreateAsset<UsageTime>();
        asset.SheetName = "MySpreadSheet";
        asset.WorksheetName = "UsageTime";
        EditorUtility.SetDirty(asset);        
    }
    
}