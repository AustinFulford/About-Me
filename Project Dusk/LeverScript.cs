using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeverScript : MonoBehaviour
{
    private bool leverTouch = false;

    public Animator animator;

    public Collider2D playerCollider;

    public Collider2D selfCollider;

    [SerializeField] TextMeshProUGUI m_Object;

    bool movePlayer = false;

    GameObject player;

    public SpriteRenderer textBackground;

    public GameObject controlsText;
    public GameObject controlBackground;
    public GameObject decisionsText;
    public GameObject decisionBackground;

    //Target position for lever transition
    public Transform target;

    void OnTriggerEnter2D(Collider2D playerCollider)
    {
        leverTouch = true;

        m_Object.text = "Want To Move Foward? Press E";

        textBackground.enabled = true;
    }

    void OnTriggerExit2D(Collider2D playerCollider)
    {
        leverTouch = false;

        selfCollider.enabled = false;

        controlsText.SetActive(false);
        controlBackground.SetActive(false);
        decisionsText.SetActive(false);
        decisionBackground.SetActive(false);
    }

    void Update()
    {
        if (leverTouch == true && Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("LeverTouched", true);

            movePlayer = true;

            MovePlayer(movePlayer);
        }
    }

    void MovePlayer(bool move)
    {
        if (move)
        {
            player = GameObject.Find("Player");

            player.transform.position = target.position;
        }
           
    }

}
