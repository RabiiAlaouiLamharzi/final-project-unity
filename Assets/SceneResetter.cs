using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneResetter : MonoBehaviour
{
    private Renderer buttonRenderer;

    private void Awake()
    {
        buttonRenderer = GetComponent<Renderer>();
    }

    public void ResetScene()
    {
        Debug.Log("Resetting Scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnMouseDown()
    {
        ResetScene();
    }

    private void OnMouseEnter()
    {
        buttonRenderer.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        buttonRenderer.material.color = Color.white;
    }

    public void OnActivate(XRBaseInteractor interactor)
    {
        ResetScene();
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