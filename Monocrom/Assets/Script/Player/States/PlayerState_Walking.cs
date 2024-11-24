using UnityEngine;

public class PlayerState_Walking : PlayerState{
    public PlayerState_Walking(PlayerController controller) : base(controller){}

    public override void Enter(){
        Debug.Log("PLAYER: Entering Walking State");
        controller.SetAnimation("isWalking", true);
    }

    public override void Update(){
        if(Input.GetKey(KeyCode.A)){
            controller.Move(-1);
        }else if(Input.GetKey(KeyCode.D)){
            controller.Move(1);
        }else{
            controller.ChangeState(new PlayerState_Idle(controller));
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            controller.ChangeState(new PlayerState_Jumping(controller));
        }
    }

    public override void Exit(){
        controller.SetAnimation("isWalking", false);
        Debug.Log("PLAYER: Exiting Walking State");
    }
}