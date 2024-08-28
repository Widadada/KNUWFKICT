using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Ardunity;
using UnityEngine.Purchasing;
using System;

public class GameControl : MonoBehaviour
{
    //[SerializeField] GameObject gameOver;
    [SerializeField] float playTime = 120f; // 게임 시간 2분으로 설정
    private Renderer[] cards;
    private bool gameEnded = false; // 게임 종료 상태를 추적하기 위한 변수

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Image winnerImage;
    [SerializeField] Sprite blueTeamSprite;
    [SerializeField] Sprite redTeamSprite;
    [SerializeField] Sprite drawSprite;
    [SerializeField] Button homeButton;

    public void ReturnToHome(){
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        RemainTime.rTime = playTime;
        SceneManager.LoadScene("Home");
    }


    void Start()
    {
        // 모든 카드를 찾습니다.
        cards = FindObjectsOfType<Renderer>();
        gameOverPanel.SetActive(false);
        homeButton.onClick.AddListener(ReturnToHome);
    }

    void Update()
    {
        if (!gameEnded)
        {
            EndTime();
        }
    }

    void EndTime()
    {
        if (RemainTime.rTime <= 0)
        {
            Time.timeScale = 0; // 게임을 일시정지합니다.
            gameEnded = true; // 게임 종료 상태로 설정
            DetermineWinner(); // 승자를 결정하고 텍스트로 표시
            gameOverPanel.SetActive(true);
            Debug.Log("Game Over Panel Activated!");
        }
    }

    void DetermineWinner()
    {
        int blueCount = 0;
        int redCount = 0;

        // 모든 카드의 색을 검사하여 카운트
        int i = 0;
        foreach (Renderer card in cards)
        {
            if (card.material.color == Color.blue)
            {
                blueCount++;
            }
            else if (card.material.color == Color.red)
            {
                redCount++;
            }
            Debug.Log(i + " " + card.material.color);
            i += 1;
        }

        if(blueCount > redCount){
            winnerImage.sprite = blueTeamSprite;
        }
        else if(redCount>blueCount){
            winnerImage.sprite = redTeamSprite;
        }
        else{
            winnerImage.sprite=drawSprite;
        }

    }

   /* public void restartGame()
    {
        //gameOver.gameObject.SetActive(false);
        Time.timeScale = 1;
        RemainTime.rTime = playTime;
        SceneManager.LoadScene("GetTime");
    }*/
}
