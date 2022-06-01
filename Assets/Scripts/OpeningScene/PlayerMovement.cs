using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	Rigidbody2D rb;
	Animator anim;
	float dirX, moveSpeed = 5f;
	bool facingRight = false;
	Vector3 localScale;

	[SerializeField] private AudioSource footsteps;
	[SerializeField] private AudioSource footsteps2;
	[SerializeField] private AudioSource shuffle;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		localScale = transform.localScale;
	}

	public bool canDoRun = true;
	public bool canDoWalk = true;
	public static bool canMove = true;

	// Update is called once per frame
	void Update()
	{

		if (DialogueManager.isActive == true)
		{
			anim.SetBool("walk", false);
			anim.SetBool("run", false);
			return;
		}
		else if (DialogueManagerCat.isActive == true)
		{
			Debug.Log("dialogue");
			anim.SetBool("talkingWithCat", true);
			return;
		}
		else if (DialogueManagerCat.isActive != true)
		{
			anim.SetBool("talkingWithCat", false);
		}

		if (DialogueManagerCat2.isActive == true)
		{
			Debug.Log("dialogue");
			anim.SetBool("talkingWithCat", true);
			anim.SetBool("walk", false);
			anim.SetBool("run", false);
			return;
		}

		if (TimelineManager.timelineActive == true)
        {
			return;
        }
		else if (TimelineManagerSecondScene.timelineActive == true)
			{
			footsteps.Stop();
			footsteps2.Stop();
			return;
			}
		else if (TimelineManagerCat.timelineActive == true)
		{
			anim.SetBool("walk", false);
			anim.SetBool("run", false);
			return;
		}
		else if (TimelineManagerTookItem.timelineActive == true)
        {
			return;
        }
		else if (ItemImageTimeline.timelineActive == true)
        {
			return;
        }
		else if (WalkingTrigger.timelineActive == true)
        {
			return;
        }


		if (canDoRun == true && Input.GetKey(KeyCode.LeftShift))
		{
			moveSpeed = 7f;
		}
		else if (canDoWalk == true)
			moveSpeed = 5f;

		SetAnimationState();

		if (canMove == true)
        {
			dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
		}

	}

	void FixedUpdate()
	{
			rb.velocity = new Vector2(dirX, rb.velocity.y);
	}

	void LateUpdate()
	{
		CheckWhereToFace();
	}

	private void OnTriggerStay2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Walk")
		{
			canDoRun = false;
		}
		if (collision.gameObject.tag == "HeadGrab")
        {
			canDoRun = false;
			Debug.Log("panic");

			anim.SetTrigger("panic");
			anim.SetBool("inPanic", true);
			moveSpeed = 3f;
		}
		if (collision.gameObject.tag == "Item" && Input.GetKey(KeyCode.E))
		{
			Debug.Log("AHHH");
			anim.SetTrigger("takeItem");
			canDoRun = false;
			canDoWalk = false;
		}
		else if (PickUpItem.isDestroyed == true && collision.gameObject.tag == "ThisThing")
        {
			canDoRun = true;
			canDoWalk = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Walk")
		{
			moveSpeed = 7f;
			canDoRun = true;
		}
		else if (collision.gameObject.tag == "HeadGrab")
		{
			anim.SetBool("inPanic", false);
		}
	}

	void SetAnimationState()
	{
		if (dirX == 0)
		{
			anim.SetBool("run", false);
			anim.SetBool("walk", false);
		}

		if (Mathf.Abs(dirX) == 5 && rb.velocity.y == 0)
		{
			anim.SetBool("walk", true);
		}

		if (Mathf.Abs(dirX) == 7 && rb.velocity.y == 0)
		{
			anim.SetBool("run", true);

		}
		else
		{
			anim.SetBool("run", false);
		}
	}

	void CheckWhereToFace()
	{
		if (dirX > 0 && PauseMenu.isPaused == false)
			facingRight = true;
		else if (dirX < 0 && PauseMenu.isPaused == false)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)) && PauseMenu.isPaused == false)
			localScale.x *= -1;

		transform.localScale = localScale;

	}

	void Footsteps()
    {
		footsteps.Play();
	}

	void Footsteps2()
	{
		footsteps2.Play();
	}

	void Shuffle()
	{
		shuffle.Play();
	}
}
