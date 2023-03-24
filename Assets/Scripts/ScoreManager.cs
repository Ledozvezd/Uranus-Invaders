using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private EnemyCreator _enemyCreator;
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private GameObject _menu;
    [SerializeField] private TMP_Text _winText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _livesText;
    private void Update()
    {
        scoreText.text = score.ToString();
        ShowMenu();
    }
    public void Kill()
    {
        score += 100;
    }
    public void ShowMenu()
    {
        if (score == 1000)
        {
            _menu.SetActive(true);
            Destroy(_enemyCreator);
            score += 1000 * (_player.health-1);
            Destroy(_player);
            _winText.text = "Вы победили!";
            _scoreText.text = score.ToString();
            _livesText.text = "Награда за оставшиеся жизни: " + 1000 * (_player.health - 1);
        }
        if (_player.health == 0)
        {
            _menu.SetActive(true);
            Destroy(_enemyCreator);
            _winText.text = "Вы проиграли";
            _scoreText.text = score.ToString();
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
