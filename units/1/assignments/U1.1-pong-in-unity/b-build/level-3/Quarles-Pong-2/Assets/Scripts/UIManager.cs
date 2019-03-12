﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
  
  public int winningScore = 7;
  
  // References to bound objects.
  public BoundController leftBound, rightBound;
  
  // Game state.
  private bool gameOver, leftWon, rightWon;
  
  // Objects to display on pause and win.
  private GameObject[] pauseObjects, winObjects;
  private GameObject ballSpawner;

  // Use this for initialization
  void Start() {
    ballSpawner = GameObject.Find("BallSpawner");
    pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
    winObjects = GameObject.FindGameObjectsWithTag("ShowOnWin");
    hideWin();
  }

  // Update is called once per frame
  void Update() {
    // Use the p button to pause and resume the game
    if (Input.GetKeyDown(KeyCode.P)) {
        pauseControl();
    }

    if (rightBound.opponentScore >= winningScore) {
      gameOver = true;
    } else if (leftBound.playerScore >= winningScore) {
      gameOver = true;
    }

    if (gameOver) {
      Time.timeScale = 0;
      showWin();
      // Ugly! Maybe hang on to reference to the button?
      foreach (var g in pauseObjects) {
        if (g.name == "ResetButton") {
          // Make it active so we can start the game again.
          g.SetActive(true);
        }
      }
      // Hide ball by turning off BallSpawner.
      ballSpawner.SetActive(false);
    }
  }

  // Reloads current Level
  public void Reload() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  
  public void pauseControl() {
    if (Time.timeScale == 1) {
      Time.timeScale = 0;
      showPaused();
    } else if (Time.timeScale == 0) {
      Time.timeScale = 1;
      hidePaused();
    }
  }

  // Shows objects with ShowOnPause tag
  public void showPaused() {
    foreach (GameObject g in pauseObjects) {
      g.SetActive(true);
    }
  }

  // Hides objects with ShowOnPause tag
  public void hidePaused() {
    foreach (GameObject g in pauseObjects) {
      g.SetActive(false);
    }
  }

  private void showWin() {
    foreach (var g in winObjects) {
      g.SetActive(true);
    }
  }

  private void hideWin() {
    foreach (var g in winObjects) {
      g.SetActive(false);
    }
  }

  // Loads inputted level
  public void LoadLevel(string scene) {
    SceneManager.LoadScene(scene);
  }
}