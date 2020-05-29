using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //場景管理器 更換場景都要載入這個
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [Header("手榴彈數量")]
    public Text textGCount;
    [Header("分數")]
    public Text textScore;



    private int GCount = 5;
    private int score;

    //private ThreePoint threePoint;
    public Three threeM;
    public Four fourM;
    public Five fiveM;




    private void Start()
    {
        //threePoint = FindObjectOfType<ThreePoint>();
        threeM = FindObjectOfType<Three >();
        fourM = FindObjectOfType<Four>();
        fiveM = FindObjectOfType<Five>();

    }


    public void UseBall()
    {
        //籃球數量修改
        GCount--;  // 數量遞減
        textGCount.text = "手榴彈剩餘 : "+GCount+""; //更新文字
    }

    public void Rplayer()
    {
        //場景管理器.載入場景("場景名稱")
        SceneManager.LoadScene("手榴彈");
    }


    private void OnTriggerExit(Collider other)
    {
        
         if (threeM.threeSwitch == true)
        {
            score += 3;

        }
       else if (fourM.fourSwitch == true)
        {
            score += 4;
        }
       else if (fiveM.fiveSwitch == true)
        {
            score += 5;
        }
        textScore.text = "分數 : " + score;
    }

    public void Quit() 
    {
        //應用程式.離開遊戲()-- - 適用於PC、手機
        Application.Quit();
    }
}
