using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProcess : MonoBehaviour
{
    public GameObject dialogWindowUI;
    private bool isDialogActive = false;

    public Dialogs dialogs = new Dialogs();

    public Bar Energy;
    public Bar Faith;
    public Bar Satiety;

    // Start is called before the first frame update
    void Start()
    {
        Energy.setValue(50);
        Faith.setValue(0);
        Satiety.setValue(50);
        dialogWindowUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (isDialogActive)
            {
                hideDialog();
                isDialogActive = false;
            }
            else
            { 
                showDialog();
                isDialogActive = true;
            }
        }
    }


    private void showDialog()
    {
        dialogWindowUI.SetActive(true);

    }

    private void hideDialog()
    {
        dialogWindowUI.SetActive(false);
    }
}