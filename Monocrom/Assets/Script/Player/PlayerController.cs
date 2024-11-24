using UnityEngine;
public class PlayerController : MonoBehaviour{
    private PlayerState currentState;

    [Header("Movement Settings")]
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float jumpForce = 10f;

    public Rigidbody2D rb;
    private Animator _animator;

    public bool isGrounded;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        ChangeState(new PlayerState_Idle(this));
    }
    public void Fall()
    {
        if (isGrounded) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        }
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, -jumpForce);
    }
    void Update(){
        currentState.Update();
    }

    public void ChangeState(PlayerState newState){
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void Move(float direction){
        rb.linearVelocity = new Vector2(direction * speed,  rb.linearVelocity.y);
    }

    public void Jump(){
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    public void SetAnimation(string animationName, bool value){
        _animator.SetBool(animationName, value);
    }
}