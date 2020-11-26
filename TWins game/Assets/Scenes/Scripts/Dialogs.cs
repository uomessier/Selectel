using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogs
{
    [System.Serializable]
    public struct OptionItem
    {
        public string Text;
        public string Answer;

        public int EnergyChange;
        public int FaithChange;
        public int SatietyChange;

        public int NextDialog;

        public OptionItem(string text, string answer, int energyChange, int faithChange, int satietyChange, int nextDialog)
        {
            Text = text;
            Answer = answer; 
            EnergyChange = energyChange; FaithChange = faithChange; SatietyChange = satietyChange; 
            NextDialog = nextDialog;
        }
    };
    
    [System.Serializable]
    public struct DialogItem
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
    };

    public List<DialogItem> dialogs;

    // Start is called before the first frame update
    void Start()
    {
        dialogs = new List<DialogItem>();
        dialogs.Add(new DialogItem(1,
                                   20, 30,
                                   30, 40,
                                   40, 50,
                                   "Единообразность будней на корабле сводит с ума. Бабки от скуки снова кормят голубей семками."
                                   )
                   );

        dialogs[0].Options.Add(new OptionItem("Отправить  божественное предупреждение: \"Чревоугодие - грех, не склоняйте к нему братьев ваших меньших\".",
                                                    "Бабки внемли предупреждению и остановились! Голуби смирились, но ненадолго.",
                                                    10, 20, -20,
                                                    -1)
                              );
        dialogs[0].Options.Add(new OptionItem("Отравить семки и проучить обжор-голубей.",
                                                    "Игнорировать происходящее.",
                                                    -10, -10, -30,
                                                    -1)
                              );
        dialogs[0].Options.Add(new OptionItem("Отправить  божественное предупреждение: \"Чревоугодие - грех, не склоняйте к нему братьев ваших меньших.\".",
                                                    "О нет, корабль тонет в голубином помете!",
                                                    -10, 0, 30,
                                                    -1)
                              );
    }

}
