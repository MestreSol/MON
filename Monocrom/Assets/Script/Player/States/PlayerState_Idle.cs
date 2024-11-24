using UnityEngine;

public class PlayerState_Idle : PlayerState{
    public PlayerState_Idle(PlayerController controller) : base(controller){}

    public override void Enter(){
        Debug.Log("PLAYER: Entering Idle State");
        controller.SetAnimation("isIdle", true);
    }

    public override void Update(){
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            controller.ChangeState(new PlayerState_Walking(controller));
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            controller.ChangeState(new PlayerState_Jumping(controller));
        }
    }

    public override void Exit(){
        controller.SetAnimation("isIdle", false);
        Debug.Log("PLAYER: Exiting Idle State");
    }
}