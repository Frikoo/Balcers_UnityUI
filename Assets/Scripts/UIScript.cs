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
    public GameObject imageField;
    public Sprite[] sprites;
    public GameObject heightSlider;
    public GameObject widthSlider;


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
    public void ChangeSprite(int val)
    {
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

    public void Height()
    {
        float currentValue = heightSlider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector3(
            imageField.transform.localScale.x,
            currentValue,
            imageField.transform.localScale.z
        );
    }

    public void Width()
    {
        float currentValue = widthSlider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector3(
            currentValue,
        imageField.transform.localScale.y,
        imageField.transform.localScale.z
        );
    }
}
