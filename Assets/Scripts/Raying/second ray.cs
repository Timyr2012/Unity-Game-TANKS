using UnityEngine;

public class RaycastColorChanger : MonoBehaviour
{
    [Header("Кольори")]
    public Color hoverColor = Color.yellow;   // при наведенні
    public Color clickColor = Color.red;     // при кліку

    private GameObject lastHovered;           // попередній об'єкт
    private Color lastOriginalColor;     // його оригінальний колір

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Renderer rend = hit.transform.GetComponent<Renderer>();

            if (rend != null)
            {
                // Новий об'єкт під курсором — відновлюємо попередній
                if (lastHovered != hit.transform.gameObject)
                {
                    RestoreLastColor();
                    lastHovered = hit.transform.gameObject;
                    lastOriginalColor = rend.material.color;
                    rend.material.color = hoverColor;
                }

                // Лівий клік — фарбуємо в clickColor
                if (Input.GetMouseButtonDown(0))
                {
                    rend.material.color = clickColor;
                    Debug.Log("Клік по: " + hit.transform.name);
                }
            }
        }
        else
        {
            // Курсор не на жодному об'єкті
            RestoreLastColor();
            lastHovered = null;
        }
    }

    void RestoreLastColor()
    {
        if (lastHovered == null) return;

        Renderer rend = lastHovered.GetComponent<Renderer>();
        if (rend != null)
            rend.material.color = lastOriginalColor;
    }
}