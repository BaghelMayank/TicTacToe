using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeScript : MonoBehaviour
{
    Boolean checker;
    int Xplusone = 0;
    int Oplusone = 0;

    [Header("Button Text")]
    public TextMeshProUGUI btnText1 = null;
    public TextMeshProUGUI btnText2 = null;
    public TextMeshProUGUI btnText3 = null;
    public TextMeshProUGUI btnText4 = null;
    public TextMeshProUGUI btnText5 = null;
    public TextMeshProUGUI btnText6 = null;
    public TextMeshProUGUI btnText7 = null;
    public TextMeshProUGUI btnText8 = null;
    public TextMeshProUGUI btnText9 = null;

    public TextMeshProUGUI btnResetGame = null;
    public TextMeshProUGUI btnNewGame = null;
    public TextMeshProUGUI msgFeedback = null;

    public TextMeshProUGUI txtPlayerX;
    public TextMeshProUGUI txtPlayerO;

    [Header("Button")]
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btn7;
    public Button btn8;
    public Button btn9;
    public Button btnQuit;

    [Header("Image Cross")]
    public GameObject Img1;
    public GameObject Img2;
    public GameObject Img3;
    public GameObject Img4;
    public GameObject Img5;
    public GameObject Img6;
    public GameObject Img7;
    public GameObject Img8;

    public void Start()
    {
        btnResetGame_Click();
    }

    public void score()
    {
        // Parse Player X score if not empty
        if (!string.IsNullOrEmpty(txtPlayerX.text))
        {
            Xplusone = int.Parse(txtPlayerX.text);
        }

        // Parse Player O score if not empty
        if (!string.IsNullOrEmpty(txtPlayerO.text))
        {
            Oplusone = int.Parse(txtPlayerO.text);
        }

        // Check conditions for Player X winning
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X")
        {
            
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img1.SetActive(true);
            Button_DisEnable();
        }
        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img2.SetActive(true);
            Button_DisEnable();
        }
        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            btnText9.color = Color.yellow;
            btnText1.color = Color.yellow;
            btnText5.color = Color.yellow;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img3.SetActive(true);
            Button_DisEnable();
        }
        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img4.SetActive(true);
            Button_DisEnable();
        }
        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText3.color = Color.green;
            btnText6.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img5.SetActive(true);
            Button_DisEnable();
        }
        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText2.color = Color.cyan;
            btnText5.color = Color.cyan;
            btnText8.color = Color.cyan;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img6.SetActive(true);
            Button_DisEnable();
        }
        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img7.SetActive(true);
            Button_DisEnable();
        }
        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            txtPlayerX.text = Convert.ToString(Xplusone + 1);
            Img8.SetActive(true);
            Button_DisEnable();
        }

        // Check conditions for Player O winning
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img1.SetActive(true);
            Button_DisEnable();
        }
        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img2.SetActive(true);
            Button_DisEnable();
        }
        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            btnText9.color = Color.yellow;
            btnText1.color = Color.yellow;
            btnText5.color = Color.yellow;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img3.SetActive(true);
            Button_DisEnable();
        }
        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.gray;
            btnText5.color = Color.gray;
            btnText7.color = Color.gray;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img4.SetActive(true);
            Button_DisEnable();
        }
        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText3.color = Color.green;
            btnText6.color = Color.green;
            btnText9.color = Color.green;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img5.SetActive(true);
            Button_DisEnable();
        }
        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText2.color = Color.cyan;
            btnText5.color = Color.cyan;
            btnText8.color = Color.cyan;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img6.SetActive(true);
            Button_DisEnable();
        }
        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText4.color = Color.red;
            btnText5.color = Color.red;
            btnText6.color = Color.red;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img7.SetActive(true);
            Button_DisEnable();
        }
        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText7.color = Color.blue;
            btnText8.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedback.text = "The Winner is Player O";
            txtPlayerO.text = Convert.ToString(Oplusone + 1);
            Img8.SetActive(true);
            Button_DisEnable();
        }
    }

    public void Button_Enable()
    {
        btn1.interactable = true;
        btn2.interactable = true;
        btn3.interactable = true;
        btn4.interactable = true;
        btn5.interactable = true;
        btn6.interactable = true;
        btn7.interactable = true;
        btn8.interactable = true;
        btn9.interactable = true;
    }

    public void Button_DisEnable()
    {
        btn1.interactable = false;
        btn2.interactable = false;
        btn3.interactable = false;
        btn4.interactable = false;
        btn5.interactable = false;
        btn6.interactable = false;
        btn7.interactable = false;
        btn8.interactable = false;
        btn9.interactable = false;
    }

    public void btnResetGame_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";

        btnText1.color = Color.white;
        btnText2.color = Color.white;
        btnText3.color = Color.white;
        btnText4.color = Color.white;
        btnText5.color = Color.white;
        btnText6.color = Color.white;
        btnText7.color = Color.white;
        btnText8.color = Color.white;
        btnText9.color = Color.white;

        msgFeedback.text = "";

        Img1.SetActive(false);
        Img2.SetActive(false);
        Img3.SetActive(false);
        Img4.SetActive(false);
        Img5.SetActive(false);
        Img6.SetActive(false);
        Img7.SetActive(false);
        Img8.SetActive(false);

        Button_Enable();
    }

    public void btnNewGame_Click()
    {
        btnResetGame_Click();

        txtPlayerX.text = "0";
        txtPlayerO.text = "0";
    }

    public void btn1_Click()
    {
        if (checker == false)
        {
            btnText1.text = "X";
            checker = true;
        }
        else
        {
            btnText1.text = "O";
            checker = false;
        }
        score();
        btn1.interactable = false;
    }

    public void btn2_Click()
    {
        if (checker == false)
        {
            btnText2.text = "X";
            checker = true;
        }
        else
        {
            btnText2.text = "O";
            checker = false;
        }
        score();
        btn2.interactable = false;
    }

    public void btn3_Click()
    {
        if (checker == false)
        {
            btnText3.text = "X";
            checker = true;
        }
        else
        {
            btnText3.text = "O";
            checker = false;
        }
        score();
        btn3.interactable = false;
    }

    public void btn4_Click()
    {
        if (checker == false)
        {
            btnText4.text = "X";
            checker = true;
        }
        else
        {
            btnText4.text = "O";
            checker = false;
        }
        score();
        btn4.interactable = false;
    }

    public void btn5_Click()
    {
        if (checker == false)
        {
            btnText5.text = "X";
            checker = true;
        }
        else
        {
            btnText5.text = "O";
            checker = false;
        }
        score();
        btn5.interactable = false;
    }

    public void btn6_Click()
    {
        if (checker == false)
        {
            btnText6.text = "X";
            checker = true;
        }
        else
        {
            btnText6.text = "O";
            checker = false;
        }
        score();
        btn6.interactable = false;
    }

    public void btn7_Click()
    {
        if (checker == false)
        {
            btnText7.text = "X";
            checker = true;
        }
        else
        {
            btnText7.text = "O";
            checker = false;
        }
        score();
        btn7.interactable = false;
    }

    public void btn8_Click()
    {
        if (checker == false)
        {
            btnText8.text = "X";
            checker = true;
        }
        else
        {
            btnText8.text = "O";
            checker = false;
        }
        score();
        btn8.interactable = false;
    }

    public void btn9_Click()
    {
        if (checker == false)
        {
            btnText9.text = "X";
            checker = true;
        }
        else
        {
            btnText9.text = "O";
            checker = false;
        }
        score();
        btn9.interactable = false;
    }

    public void Quit()
    {
        Application.Quit();

    }
}
