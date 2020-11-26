using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OptionItem
{
    public string Text;
    public string Answer;

    public int EnergyChange;
    public int FaithChange;
    public int SatietyChange;

    public string NextDialogue;

    public OptionItem(string text, string answer, int energyChange, int faithChange, int satietyChange, string nextDialog)
    {
        Text = text;
        Answer = answer;
        EnergyChange = energyChange; FaithChange = faithChange; SatietyChange = satietyChange;
        NextDialogue = nextDialog;
    }
}
