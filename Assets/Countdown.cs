using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

    private Animator _anims;

    private void Awake()
    {
        _anims = GetComponent<Animator>();
    }

    public void PlayAnim()
    {
        this.gameObject.SetActive(true);
        _anims.SetTrigger("Countdown");
        Invoke("Hide", 4);
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
