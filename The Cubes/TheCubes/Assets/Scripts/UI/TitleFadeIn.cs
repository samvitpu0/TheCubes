using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleFadeIn : MonoBehaviour
{
    static bool titleShown = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!titleShown)
        {
            titleShown = true;
            StartCoroutine("FadeIn");
        }
    }

    /// <summary>
    /// Coroutine to FadeIn the title
    /// </summary>
    /// <returns></returns>
    private IEnumerator FadeIn()
    {
        var _titleCanvasGroup = GetComponent<CanvasGroup>();

        // Speed by which title appears
        float _speed = 2f;

        while (_titleCanvasGroup.alpha < 1)
        {
            _titleCanvasGroup.alpha += Time.deltaTime / _speed;
            yield return null;
        }
    }
}
