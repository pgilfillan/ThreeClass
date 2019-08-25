using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public Sprite warriorSprite;
    public Sprite archerSprite;
    public Sprite mageSprite;

    private ClassState currClassState = ClassState.Warrior;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontal, vertical, 0);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<SpriteRenderer>().sprite = warriorSprite;
            currClassState = ClassState.Warrior;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<SpriteRenderer>().sprite = archerSprite;
            currClassState = ClassState.Archer;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GetComponent<SpriteRenderer>().sprite = mageSprite;
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

    private enum ClassState
    {
        Warrior,
        Archer,
        Mage
    }
}
