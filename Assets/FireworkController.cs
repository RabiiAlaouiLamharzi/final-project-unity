using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class FireworkController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;
    private bool isPlaying = false;
    private XRGrabInteractable interactable;

    void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    void Start()
    {
        if (particleSystem == null)
        {
            particleSystem = GetComponent<ParticleSystem>();
        }
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

    public void OnActivate(XRBaseInteractor interactor)
    {
        ToggleParticles();
    }

    private void OnMouseDown()
    {
        ToggleParticles();
    }

    public void ToggleParticles()
    {
        if (isPlaying)
        {
            particleSystem.Stop();
        }
        else
        {
            particleSystem.Play();
        }
        isPlaying = !isPlaying;
    }

    public void ResetParticules()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}