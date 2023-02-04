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
    /// ���邭����
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
    /// �Â�����
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
    /// �V�[���������Ȃ�
    /// </summary>
    public virtual void HideScene()
    {
        sceneObj.SetActive(false);
    }


    /// <summary>
    /// �V�[����������
    /// </summary>
    public virtual void ShowScene()
    {
        sceneObj.SetActive(true);
    }

}
