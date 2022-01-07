using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StuckTextScript : MonoBehaviour
{
    public Collider2D playerCollider;//Variables, public and otherwise

    public Collider2D selfCollider;

    public Animator animator;

    public TextMeshProUGUI helpText;
    public TextMeshProUGUI choice1Text;
    public TextMeshProUGUI choice2Text;

    public GameObject choice1Platform;
    public GameObject choice2Platform;

    void OnTriggerEnter2D(Collider2D collision)//On trigger enter for collider
    {
        selfCollider.enabled = false;//turn itself off so no duplicate detection

        animator.SetBool("triggerTouched", true);//Set animation on

        StartCoroutine(delayCoroutine());//Start coroutine
    }

    IEnumerator delayCoroutine()
    {
        yield return new WaitForSeconds(8f);//After 8 seconds

        helpText.text = "Just Ask For Help";//Change text

        choice1Platform.SetActive(true);//set platforms to active
        choice2Platform.SetActive(true);

        choice1Text.alpha = 255;//And make the text that is already there, visible
        choice2Text.alpha = 255;
    }
}
