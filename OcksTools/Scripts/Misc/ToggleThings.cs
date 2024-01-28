using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleThings : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Image background;
    public Image checkmark;
    public Toggle things;
    public int togglier;

    public void SetVal()
    {
        switch (togglier)
        {
            case 0:
                things.isOn = Gamer.Instance.AllowIllegalImmigration;
                break;
            case 1:
                things.isOn = Gamer.Instance.Junkyard;
                break;
        }
    }


    public void UpdateValues()
    {
        bool e = things.isOn;
        checkmark.color = Gamer.Instance.main_colors[1];
        text.color = e ? checkmark.color : background.color;

        switch (togglier)
        {
            case 0:
                Gamer.Instance.AllowIllegalImmigration = things.isOn;
                break;
            case 1:
                Gamer.Instance.Junkyard = things.isOn;
                break;
        }
    }
}
