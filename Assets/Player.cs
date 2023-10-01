using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        if (mousePos.x > 0) mousePos.x = 0;
        //if (mousePos.y > 3.47f) mousePos.y = 3.47f;
        //if (mousePos.y < -3.47f) mousePos.y = -3.47f;
        //if (mousePos.x < 7.46f) mousePos.x = 7.46f;
        GetComponent<Rigidbody2D>().MovePosition(mousePos);
        print(mousePos);
    }
}
