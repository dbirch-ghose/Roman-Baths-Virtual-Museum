using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;

    public Transform playerPos;

    private bool moved = false;

    //if player presses 'f' and !moved
    //move player to pos2, make moved == true
    //if player presses 'f' and moved == true
    //move player to pos1 and make !moved 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key Pressed");
            if (!moved) 
            {
                TeleportPlayer(pos2);
                moved = true;
            }
            else
            {
                TeleportPlayer(pos1);
                moved = false;
            }
        }
    }


    private void TeleportPlayer(Transform pos)
    {
        CharacterController controller = playerPos.GetComponent<CharacterController>();

        if (controller != null)
            controller.enabled = false;

        playerPos.position = pos.position;

        if (controller != null)
            controller.enabled = true;
    }

}
