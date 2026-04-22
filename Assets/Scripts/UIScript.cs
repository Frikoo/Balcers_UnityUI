using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject Kruze;
    public GameObject Lade;
    public GameObject Diskete;
    public GameObject Kivere;
    public GameObject Kauss;
    public GameObject Dimants;
    public GameObject Zobens;
    public GameObject Lata;
    public GameObject Lampa;
    public GameObject toggleLeft;
    public GameObject toggleRight;
    public GameObject imageField;
    public Sprite[] sprites;
    public GameObject rotationSlider;
    public GameObject scaleSlider;


    public void Riki1Toggle(bool val)
    {
        Kruze.SetActive(val);
        Lade.SetActive(val);
        Diskete.SetActive(val);
    }
    public void Riki2Toggle(bool val)
    {
        Kivere.SetActive(val);
        Kauss.SetActive(val);
        Dimants.SetActive(val);
    }
    public void Riki3Toggle(bool val)
    {
        Zobens.SetActive(val);
        Lata.SetActive(val);
        Lampa.SetActive(val);
    }


    public void Flip(int val)
    {
        Kruze.transform.localScale = new Vector2(val, 1);
    }

    public void ChangeSprite(int val)
    {
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

    public void Rotate()
    {
        float currentValue = rotationSlider.GetComponent<Slider>().value;
        imageField.transform.rotation = Quaternion.Euler(0, 0, currentValue * 360);
    }

    public void Scale()
    {
        float currentValue = scaleSlider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f * currentValue, 1f * currentValue);
    }
}
