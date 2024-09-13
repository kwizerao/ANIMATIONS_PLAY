using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


public class BossController : MonoBehaviour
{
    public Animator anim;

    [SerializeField]
    [Multiline]
    private string Description = "Q FOR IDLE \n W FOR CAPOEIRA \n E FOR FALL FLAT";
    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        // Q FOR IDLE
        // W FOR CAPOEIRA
        // E FOR FALL FLAT

        if(Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("isBreathing", true);
            anim.SetBool("isFallenFlat", false);
            anim.SetBool("isCapoeira", false);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("isBreathing", false );
            anim.SetBool("isFallenFlat", false);
            anim.SetBool("isCapoeira", true );
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isBreathing", false ) ;
            anim.SetBool("isFallenFlat", true);
            anim.SetBool("isCapoeira", false);

        }
    }
}


