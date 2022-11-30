using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    public void SetTankController(TankController _tankcontroller)
    {
        _tankcontroller = tankController;
    }
}
