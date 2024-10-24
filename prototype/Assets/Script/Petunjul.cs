using UnityEngine;

public class Petunjul : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject button1next;
    public GameObject button2prev;
    public GameObject button2next;
    public GameObject button3prev;

    public void TOPAGE1()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
        button2prev.SetActive(false);
        button2next.SetActive(false);
        button1next.SetActive(true);
    }
    public void TOPAGE2()
    {
        page1.SetActive(false);
        page2.SetActive(true);
        page3.SetActive(false);
        button1next.SetActive(false);
        button2prev.SetActive(true);
        button2next.SetActive(true);
        button3prev.SetActive(false);
    }
    public void TOPAGE3()
    {
        page1.SetActive(false);
        page2.SetActive(false);
        page3.SetActive(true);
        button3prev.SetActive(true);
        button2prev.SetActive(false);
        button2next.SetActive(false);
    }
}
