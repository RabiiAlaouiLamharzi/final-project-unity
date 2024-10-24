using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class MagnetController : MonoBehaviour
{
    public bool isActivated = false;
    public float magneticForce = 5f;
    public Button activateButton;

    private Renderer magnetRenderer;
    private XRGrabInteractable interactable;

    private void Awake()
    {
        magnetRenderer = GetComponent<Renderer>();
        interactable = GetComponent<XRGrabInteractable>();
    }

    public void ToggleMagnet()
    {
        isActivated = !isActivated;

        if (isActivated)
        {
            magnetRenderer.material.color = Color.red;
            activateButton.GetComponentInChildren<TextMeshProUGUI>().text = "Deactivate Magnet";
        }
        else
        {
            magnetRenderer.material.color = Color.white;
            activateButton.GetComponentInChildren<TextMeshProUGUI>().text = "Activate Magnet";
        }
    }

    public void ResetMagnet()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnActivate(XRBaseInteractor interactor)
    {
        ToggleMagnet();
    }

    private void OnEnable()
    {
        if (interactable != null)
        {
            interactable.onActivate.AddListener(OnActivate);
        }
    }

    private void OnDisable()
    {
        if (interactable != null)
        {
            interactable.onActivate.RemoveListener(OnActivate);
        }
    }

    private void OnMouseDown()
    {
        ToggleMagnet();
    }
}