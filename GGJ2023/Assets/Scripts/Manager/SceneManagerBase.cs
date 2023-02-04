using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerBase : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] GameObject sceneObj;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>
    /// 明るくする
    /// </summary>
    public bool Fadein()
    {
        StartCoroutine(FadeinCoroutine(GameParameter.fadeinTime));
        return true;
    }

    private IEnumerator FadeinCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
    }

    /// <summary>
    /// 暗くする
    /// </summary>
    public bool Fadeout()
    {
        StartCoroutine(FadeoutCoroutine(GameParameter.fadeinTime));
        return true;
    }

    private IEnumerator FadeoutCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
    }
    
    /// <summary>
    /// シーンを見せない
    /// </summary>
    public virtual void HideScene()
    {
        sceneObj.SetActive(false);
    }


    /// <summary>
    /// シーンを見せる
    /// </summary>
    public virtual void ShowScene()
    {
        sceneObj.SetActive(true);
    }

}
