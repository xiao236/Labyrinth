using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public int currentLevel;
    private int levelToLoad;
    // Update is called once per frame
    void Update()
    {

    }
        
    public void FadeToLevel(int level)
    {
        levelToLoad = level;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeDone()
    {
        SceneManager.LoadScene(levelToLoad);
    }

}
