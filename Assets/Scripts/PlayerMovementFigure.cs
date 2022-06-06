using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFigure : MonoBehaviour
{
	Rigidbody2D rb;
	Animator anim;
	float dirX, moveSpeed = 5f;
	bool facingRight = true;
	Vector3 localScale;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		localScale = transform.localScale;
	}

	public bool canDoWalk = false;
	public static bool canMove = false;
	private bool thisThing = false;

	IEnumerator WaitForMoving()
	{
		yield return new WaitForSeconds(2);
		thisThing = true;
	}
	// Update is called once per frame
	void Update()
	{

		if (DialogueManagerFigure.dialogueEnded == false)
		{
			canDoWalk = false;
			canMove = false;
			return;
		}
		else if (DialogueManagerFigure.dialogueEnded == true && thisThing == false)
        {
			anim.SetBool("come", true);
			StartCoroutine(WaitForMoving());
			Debug.Log("Can move!");
		}
		else if (DialogueManagerFigure.dialogueEnded == true && thisThing == true)
        {
			anim.SetBool("come", false);
			canDoWalk = true;
			canMove = true;
		}

		if (TimelineManagerHoldHands.timelineActive == true)
		{
			canDoWalk = false;
			canMove = false;
			return;
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

	void SetAnimationState()
	{
		if (dirX == 0)
		{
			anim.SetBool("walk", false);
		}

		if (Mathf.Abs(dirX) == 5 && rb.velocity.y == 0)
		{
			anim.SetBool("walk", true);
		}

	}

	void CheckWhereToFace()
	{
		if (dirX > 0 && PauseMenu.isPaused == false)
			facingRight = true;
		else if (dirX < 0 && PauseMenu.isPaused == false)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)) && PauseMenu.isPaused == false && DialogueManager.dialogueEnded == true)
			localScale.x *= -1;

		transform.localScale = localScale;

	}
}
