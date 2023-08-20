using UnityEngine;

public class TouchRead : MonoBehaviour
{
    public void OnTouchToJump()
    {
        if(Jump.isOpen == true)
        {
            if (Jump.isJump2 == false)
                Jump.isJump = true;
        }
    }
}
