using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;

    public GameObject tapText;
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore1;
    public TextMeshProUGUI highScore2;
    public static UIManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("PanelUp");
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update() { }
}
