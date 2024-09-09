using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _Instance;
    public GameObject _Rain;
    public GameObject _EndPanel;

    public Text _TotalScoreText;
    public Text _TimeText;

    int _TotalScore;
    float _TotalTime = 30.0f;

    private void Awake()
    {
        _Instance = this;
        Time.timeScale = 1.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (_TotalTime > 0f)
        {
            _TotalTime -= Time.deltaTime;
        }
        else
        {
            _TotalTime = 0f;
            _EndPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        _TimeText.text = _TotalTime.ToString("N2");
    }

    void MakeRain()
    {
        Instantiate(_Rain);
    }

    public void AddScore(int score)
    {
        _TotalScore += score;
        if(_TotalScore < 0) _TotalScore = 0;
        _TotalScoreText.text = _TotalScore.ToString();
    }
}
