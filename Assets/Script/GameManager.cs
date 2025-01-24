using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int Score { get; private set; }

    public event Action<int> OnScoreChanged;
    public event Action OnGameEnd;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        // Subskrypcja zdarzenia statycznego
        Collectible.pickupEvent += HandleCollectibleCollected;
    }

    private void OnDisable()
    {
        //Odsubskrybowanie zdarzenia
        Collectible.pickupEvent -= HandleCollectibleCollected;
    }

    private void HandleCollectibleCollected()
    {
        AddScore(1);
    }

    public void AddScore(int amount)
    {
        Score += amount;
        OnScoreChanged?.Invoke(Score);

        if (Score == 4)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Gra zakoñczona!");
        OnGameEnd?.Invoke();
        SceneManager.LoadScene(2, LoadSceneMode.Single);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void tableCollectibles()
    {
        var collectibles = GameObject.FindGameObjectsWithTag("Collectibles");
        int maxScore = collectibles.Length;
        Debug.Log("Total collectibles: " + maxScore);
    }
}
