using UnityEngine;

public class PlayerState_Jumping : PlayerState{
    public PlayerState_Jumping(PlayerController controller) : base(controller){}

    public override void Enter(){
        Debug.Log("PLAYER: Entering Jumping State");
        controller.SetAnimation("isJumping", true);
        controller.Jump();
    }

    public override void Update(){
        controller.Jump();
        // Jump direction control
        if(Input.GetKey(KeyCode.A)){
            controller.Move(-1);
        }else if(Input.GetKey(KeyCode.D)){
            controller.Move(1);
        }
        if(controller.rb.linearVelocity.y < 0){
            controller.ChangeState(new PlayerState_Falling(controller));
        }
    }

    public override void Exit(){
        controller.SetAnimation("isJumping", false);
        Debug.Log("PLAYER: Exiting Jumping State");
    }
}