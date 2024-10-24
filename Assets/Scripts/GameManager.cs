using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] GameObject End;
    private GameObject[] players;

    private void Awake()
    {
        if (Instance != null) {
            DestroyImmediate(gameObject);
        } else {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this) {
            Instance = null;
        }
    }

    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    public void CheckWinState()
    {
        int aliveCount = 0;

        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].activeSelf) {
                aliveCount++;
            }
        }

        if (aliveCount <= 1) {
            Invoke(nameof(NewRound), 1.25f);
        }
    }
    private void NewRound()
    {
        End.SetActive(true);
        Time.timeScale = 0;;
    }

}
