using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Sprite warriorSprite;
    public Sprite archerSprite;
    public Sprite mageSprite;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public int health;

    private enum ClassState
    {
        Warrior,
        Archer,
        Mage
    }

    private ClassState currClassState = ClassState.Warrior;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontal, vertical, 0);

        if (Mathf.Abs(horizontal) < 0.001)
        {
            animator.SetInteger("SpeedX", 0);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("SpeedX", 1);
        }
        else
        {
            animator.SetInteger("SpeedX", -1);
        }

        if (Mathf.Abs(vertical) < 0.001)
        {
            animator.SetInteger("SpeedY", 0);
        }
        else if (vertical > 0)
        {
            animator.SetInteger("SpeedY", 1);
        }
        else
        {
            animator.SetInteger("SpeedY", -1);
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.sprite = warriorSprite;
            currClassState = ClassState.Warrior;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.sprite = archerSprite;
            currClassState = ClassState.Archer;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.sprite = mageSprite;
            currClassState = ClassState.Mage;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            switch (currClassState)
            {
                case ClassState.Warrior:
                    Debug.Log("Attacked with warrior primary");
                    break;
                case ClassState.Archer:
                    Debug.Log("Attacked with archer primary");
                    break;
                case ClassState.Mage:
                    Debug.Log("Attacked with mage primary");
                    break;
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            switch (currClassState)
            {
                case ClassState.Warrior:
                    Debug.Log("Attacked with warrior secondary");
                    break;
                case ClassState.Archer:
                    Debug.Log("Attacked with archer secondary");
                    break;
                case ClassState.Mage:
                    Debug.Log("Attacked with mage secondary");
                    break;
            }
        }
    }

    public void ReceiveDamage(int receivedDamage)
    {
        health = Mathf.Max(health - receivedDamage, 0);

        if (health == 0)
        {
            Debug.Log("Player died");
        }
    }
}
