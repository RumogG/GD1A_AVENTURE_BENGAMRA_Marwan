using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public bool CanAtk = true;


    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0.0f).normalized;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        //transform.position = transform.position + (movement/1.2f) * Time.deltaTime;
        rb.velocity = new Vector2 (movement.x, movement.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetButton("Attack") && CanAtk == true)
        {
            Atk();
            CanAtk = false;
        }

        if (HealthBar.instance.health <= 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && (Potions.instance.potionsCount > 0))
        {
            HealthBar.instance.Regen(50);
            Potions.instance.RemovePotions(1);
        }

    }

    private void AtkFalse()
    {
        if (animator.GetBool("Attack") == true)
        {
            animator.SetBool("Attack", false);
        }
    }

    private void Atk()
    {

     animator.SetBool("Attack", true);

    }

    private void AtkAtive()
    {

        CanAtk = true;

    }
}
