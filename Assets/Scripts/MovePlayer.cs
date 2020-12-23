
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag ()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);

            if (mousePos.x == 2.5f)
                player.position = new Vector2(-2.5f, player.position.y);

            if (mousePos.x == -2.5f)
                player.position = new Vector2(2.5f, player.position.y);
        }
    }
}
