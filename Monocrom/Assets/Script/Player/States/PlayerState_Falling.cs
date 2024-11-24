using UnityEngine;

public class PlayerState_Falling : PlayerState
{
    public PlayerState_Falling(PlayerController controller) : base(controller)
    {
    }

    public override void Enter()
    {
        Debug.Log("PLAYER: Entering Falling State");
        controller.SetAnimation("isFalling", true);
    }

    public override void Update()
    {
        controller.Fall();
        if (controller.isGrounded)
        {
            controller.ChangeState(new PlayerState_Idle(controller));
        }
    }

    public override void Exit()
    {
        controller.SetAnimation("isFalling", false);
        Debug.Log("PLAYER: Exiting Falling State");
    }
}
