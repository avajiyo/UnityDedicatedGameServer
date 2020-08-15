using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
///
[System.Serializable]
public class UsageTimeData
{
  [SerializeField]
  int key;
  public int Key { get {return key; } set { this.key = value;} }
  
  [SerializeField]
  string name;
  public string Name { get {return name; } set { this.name = value;} }
  
  [SerializeField]
  float usagetime_week;
  public float Usagetime_Week { get {return usagetime_week; } set { this.usagetime_week = value;} }
  
  [SerializeField]
  float usagetime_month;
  public float Usagetime_Month { get {return usagetime_month; } set { this.usagetime_month = value;} }
  
  [SerializeField]
  float usagetime_total;
  public float Usagetime_Total { get {return usagetime_total; } set { this.usagetime_total = value;} }
  
}