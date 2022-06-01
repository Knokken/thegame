using UnityEngine;
using System.Collections;

public class PlayerMovementSecond : MonoBehaviour
{

	Animator anim;

	[SerializeField] private AudioSource footsteps;
	[SerializeField] private AudioSource footsteps2;

	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if(DialogueManager.dialogueEnded == true)
        {
			anim.SetTrigger("stopHoldingHands");
        }

	}

	void FixedUpdate()
	{
		
	}

	void Footsteps()
	{
		footsteps.Play();
	}

	void Footsteps2()
	{
		footsteps2.Play();
	}
}