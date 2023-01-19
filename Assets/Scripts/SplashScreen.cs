using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public Image SplashImage;
    public string nextPage;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(4.0f);
        FadeOut();
        SceneManager.LoadScene(nextPage);
    }

    void FadeOut()
    {
        SplashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }

}
