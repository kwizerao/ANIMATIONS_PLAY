using UnityEngine;
using UnityEngine.UI;

public class SceneTransitionController : MonoBehaviour
{
    public Animator animator;

    public Button StartNextBtn;
    public Button SecondNextBtn;
    public Button SecondPreviousBtn;
    public Button ThirdPreviousBtn;



    private void Start()
    {
        animator = GetComponent<Animator>();

        StartNextBtn.onClick.AddListener(StartNext);
        SecondNextBtn.onClick.AddListener(SecondNext);
        SecondPreviousBtn.onClick.AddListener(SecondPrevious);
        ThirdPreviousBtn.onClick.AddListener(ThirdPrevious);
    }


    public void StartNext()
    {
        animator.Play("FirstScreenTransitionOut");
    }

    public void SecondNext()
    {
        animator.Play("SecondScreenTransitionOut");
    }

    public void SecondPrevious()
    {
        animator.Play("FirstScreenTransitionIn");
    }

    public void ThirdPrevious()
    {
        animator.Play("thirdScreenTransitionOut");
    }
}


