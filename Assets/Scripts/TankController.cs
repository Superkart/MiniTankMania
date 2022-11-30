using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        _tankModel = tankModel;
        _tankView = tankView;

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);

    }


}
