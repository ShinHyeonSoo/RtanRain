using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _Instance;
    public GameObject _Rain;

    public Text _TotalScoreText;

    int _TotalScore;

    private void Awake()
    {
        _Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeRain()
    {
        Instantiate(_Rain);
    }

    public void AddScore(int score)
    {
        _TotalScore += score;
        _TotalScoreText.text = _TotalScore.ToString();
    }
}
