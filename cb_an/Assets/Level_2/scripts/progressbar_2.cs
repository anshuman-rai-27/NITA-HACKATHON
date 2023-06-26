using UnityEngine;
using UnityEngine.UI;

public class progressbar_2 : MonoBehaviour
{
    public Image filledImage;
    public Image unfilledImage;
    
    [SerializeField] CollisionManager sc;

    private float targetProgress = 50f;

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
            Debug.Log("score" + progress);
            filledImage.fillAmount = progress ;
            unfilledImage.fillAmount = 1f - progress;
        }
    }
}
