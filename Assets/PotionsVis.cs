using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PotionsVis : MonoBehaviour
{
    public Sprite sprite4;
    public Sprite sprite3;
    public Sprite sprite2;
    public Sprite sprite1;
    public Sprite sprite0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Potions.instance.potionsCount == 4)
        {
            gameObject.GetComponent<Image>().sprite = sprite4;
        }

        else if (Potions.instance.potionsCount == 3)
        {
            gameObject.GetComponent<Image>().sprite = sprite3;
        }

        else if(Potions.instance.potionsCount == 2)
        {
            gameObject.GetComponent<Image>().sprite = sprite2;
        }

        else if(Potions.instance.potionsCount == 1)
        {
            gameObject.GetComponent<Image>().sprite = sprite1;
        }

        else if (Potions.instance.potionsCount == 0)
        {
            gameObject.GetComponent<Image>().sprite = sprite0;
        }
    }
}
