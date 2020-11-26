using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogItem
{
    public int DialogNum;
    
    public int EnergyMin, EnergyMax;
    public int FaithMin, FaithMax;
    public int SatietyMin, SatietyMax;

    public string Message;
    public List<OptionItem> Options;

    public DialogItem(int dialogNum, int energyMin, int energyMax, int faithMin, int faithMax, int satietyMin, int satietyMax, string message)
    {
        DialogNum = dialogNum;
        
        EnergyMin = energyMin; EnergyMax = energyMax;
        FaithMin = faithMin; FaithMax = faithMax;
        SatietyMin = satietyMin; SatietyMax = satietyMax;
        
        Message = message;
        Options = new List<OptionItem>();
    }
}
