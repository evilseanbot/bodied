using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.FinalIK;
using Normal.Realtime;
using System;

namespace Bodied
{
	
	public class BodiedAvatar : MonoBehaviour
	{
		private Animator anim;

		[ContextMenu("Configure Full Body Tracked")]
		public void ConfigureFullBody()
		{
			ConfigureStandard();

			foreach (HumanBodyBones bone in Enum.GetValues(typeof(HumanBodyBones)))
			{
				// We don't want to track the head in order to shrink it locally only for visibility reasons.
				if (anim.GetBoneTransform(bone) != null && bone != HumanBodyBones.Head)
				{
					GameObject thisBone = anim.GetBoneTransform(bone).gameObject;
					if (thisBone.GetComponent<RealtimeTransform>() == null)
						thisBone.AddComponent<RealtimeTransform>();
				}
			}

		}

		// TODO: Set up 3 point avatar configuration.

		/*
		[ContextMenu("Configure 3 Point Tracked")]
		public void ConfigureThreePoint()
		{

		}
		*/

		public void RequestOwnershipOfAllTransforms()
		{
			foreach (RealtimeTransform rt in GetComponentsInChildren<RealtimeTransform>())
				rt.RequestOwnership();
		}

		private void ConfigureStandard()
		{
			anim = GetComponent<Animator>();

			if (gameObject.GetComponent<VRIK>() == null)
			{
				VRIK vrIK = gameObject.AddComponent<VRIK>();
			}

			if (gameObject.GetComponent<RealtimeTransform>() == null)
			{
				gameObject.AddComponent<RealtimeTransform>();
			}
		}

		private void Start()
		{
			anim = GetComponent<Animator>();

			Transform head = anim.GetBoneTransform(HumanBodyBones.Head);
			head.transform.localScale = Vector3.zero;
		}
	}
}