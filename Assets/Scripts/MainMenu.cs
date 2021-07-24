using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    public int total_money;
    public Text moneyText;
    



private void Start() {
    money = PlayerPrefs.GetInt("money");
    total_money = PlayerPrefs.GetInt("total_money");
    bool isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;

    StartCoroutine(IdleFarm());
}


    public void ButtonClick() {
        money++;
        total_money++;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }

IEnumerator IdleFarm() {
    yield return new WaitForSeconds(1);
    money++;
    Debug.Log(money);
    PlayerPrefs.SetInt("money", money);
    StartCoroutine(IdleFarm());
}


public void ToAchievements() {
SceneManager.LoadScene(1);
}

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();
    }
}
