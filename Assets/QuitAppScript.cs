using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class QuitAppScript : MonoBehaviour
{
    private Renderer buttonRenderer;

    private void Awake()
    {
        buttonRenderer = GetComponent<Renderer>();
    }

    public void QuitApp()
    {
        Debug.Log("Game Over");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing in the editor
#else
        Application.Quit();
#endif
    }

    private void OnMouseDown()
    {
        QuitApp();
    }

    private void OnMouseEnter()
    {
        buttonRenderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        buttonRenderer.material.color = Color.white;
    }

    public void OnActivate(XRBaseInteractor interactor)
    {
        QuitApp();
    }

    private void OnEnable()
    {
        var interactable = GetComponent<XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.onActivate.AddListener(OnActivate);
        }
    }

    private void OnDisable()
    {
        var interactable = GetComponent<XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.onActivate.RemoveListener(OnActivate);
        }
    }
}