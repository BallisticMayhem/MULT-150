using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using TMPro;

public class HoverButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private RectTransform buttonRect;
    [SerializeField] private Vector2 padding = new Vector2(20f, 10f);
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private UnityEngine.UI.RawImage videoDisplay;

    private string originalText;
    public string hoverText = "Hovered!";
    public string clickedText = "Clicked!"; // add this field
    private bool isClicked = false; // track if button was clicked

    void Start()
    {
        originalText = buttonText.text;
        FitToText();

        RenderTexture rt = new RenderTexture(1920, 1080, 0);
        videoPlayer.targetTexture = rt;
        videoDisplay.texture = rt;

        videoDisplay.gameObject.SetActive(false); // hide on start!

        videoPlayer.loopPointReached += OnVideoFinished;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isClicked) // only show hover text if not clicked
        {
            buttonText.text = hoverText;
            FitToText();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isClicked) // only revert if not clicked
        {
            buttonText.text = originalText;
            FitToText();
        }
    }

    public void OnButtonClick()
    {
        isClicked = true;
        buttonText.text = clickedText;
        FitToText();
        videoDisplay.gameObject.SetActive(true);
        videoPlayer.Stop();
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        isClicked = false; // reset when video finishes
        buttonText.text = originalText;
        FitToText();
        videoDisplay.gameObject.SetActive(false);
        videoPlayer.Stop();
    }
    void OnDestroy()
    {
        videoPlayer.loopPointReached -= OnVideoFinished;
    }

    private void FitToText()
    {
        float maxWidth = 1020f;
        buttonText.rectTransform.sizeDelta = new Vector2(maxWidth, 0);
        buttonText.ForceMeshUpdate();

        Vector2 preferredSize = new Vector2(
            maxWidth + padding.x,
            buttonText.renderedHeight + padding.y
        );
        buttonRect.sizeDelta = preferredSize;
    }
}