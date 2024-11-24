public abstract class PlayerState{
    protected PlayerController controller;

    public PlayerState(PlayerController controller){
        this.controller = controller;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
}