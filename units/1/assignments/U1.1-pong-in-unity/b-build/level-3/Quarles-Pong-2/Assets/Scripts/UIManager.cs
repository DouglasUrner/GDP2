using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
  GameObject[] pauseObjects;

  // Use this for initialization
  void Start() {
    pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
  }

  // Update is called once per frame
  void Update() {
    // Use the p button to pause and resume the game
    if (Input.GetKeyDown(KeyCode.P)) {
      if (Time.timeScale == 1) {
        Time.timeScale = 0;
        showPaused();
      } else if (Time.timeScale == 0) {
        Time.timeScale = 1;
        hidePaused();
      }
    }
  }

  // Reloads current Level
  public void Reload() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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

  // Loads inputted level
  public void LoadLevel(string scene) {
    SceneManager.LoadScene(scene);
  }
}