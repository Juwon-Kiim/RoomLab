using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoGradeOne : MonoBehaviour
{
    public Button GoBack;
    public GameObject MainPage;
    public GameObject CurPage;

    public void GradeOneBtn()
    {
        MainPage.gameObject.SetActive(false);
        GoBack.gameObject.SetActive(true);
        CurPage.gameObject.SetActive(true);
    }
    public void GoBackBtn()
    {
        GoBack.gameObject.SetActive(false);
        CurPage.gameObject.SetActive(false);
        MainPage.gameObject.SetActive(true);
    }
}
