using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossComportement : MonoBehaviour
{
    public Animator animator;
    public bool canAtk = false;
    public float atkCount = 0;
    public int tpYes = 0;

    void Start()
    {
        StartCoroutine(ReactiveAtk());
    }
    void Update()
    {
        if(canAtk == true)
        {
            animAtk();
        }

        if(atkCount == 3)
        {
            atkCount = 0;
            TpAnim();
        }
    }

    public IEnumerator ReactiveAtk()
    {
        animator.SetBool("Atk", false);
        atkCount += 1;
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        canAtk = true;
    }

    public void ActiveCanAtk()
    {
        canAtk = true;
    }


    public void animAtk()
    {
        animator.SetBool("Atk", true);
        canAtk = false;
    }

    public void Atk()
    {
        BossAtk.instance.launchAtk();
    }

    public void TpAnim()
    {
        canAtk = false;
        animator.SetTrigger("Tp");
    }
    public void Tp()
    {
        Vector2 newPos;

        newPos.x = Random.Range(-2, -0.8f);

        newPos.y = Random.Range(-0.8f, 0.4f);

        gameObject.transform.position = newPos;

        tpYes = Random.Range(1, 10);

        if (tpYes <= 5)
        {
            TpAnim();
        }
        else
        {
            canAtk = true;
        }
    }

}
