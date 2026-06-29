using UnityEngine;

public class MousePosition2D : MonoBehaviour
{
    [SerializeField] private Camera maincamera;
   
    void Update()
    {
       Vector3 Mouseworldpos = maincamera.ScreenToWorldPoint(Input.mousePosition);
        Mouseworldpos.z = 0f;
        transform.position = Mouseworldpos;
        Debug.Log(Input.mousePosition);

        // Debug.Log(maincamera.ScreenToWorldPoint(Input.mousePosition));
    }
}
