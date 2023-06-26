using UnityEngine;
using UnityEngine.UI;

public class progressbar_1 : MonoBehaviour
{
    public Image filledImage;
    public Image unfilledImage;
    
    [SerializeField] ObjectCollector sc;

    private float targetProgress = 80f;

    void Start()
    {
        filledImage = GetComponent<Image>();
    }
    public void SetProgress(float progress)
    {
        targetProgress = Mathf.Clamp01(progress);
    }
    void Update()
    {
        float currentProgress = sc.score;
        if (currentProgress < targetProgress)
        {
            float progress = Mathf.Clamp01(currentProgress / targetProgress);
            
            filledImage.fillAmount = progress ;
            unfilledImage.fillAmount = 1f - progress;
        }
    }
}
