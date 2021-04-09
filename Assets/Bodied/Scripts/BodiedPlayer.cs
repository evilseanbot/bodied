using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

namespace Bodied
{
	public class BodiedPlayer : MonoBehaviour
	{
		public BodiedAvatar avatar;

		// Start is called before the first frame update
		void Start()
		{
			if (IsOwnedLocally())
			{
				avatar.RequestOwnershipOfAllTransforms();
			}

		}

		bool IsOwnedLocally()
		{
			return GetComponent<RealtimeTransform>().isOwnedLocallySelf;
		}


	}
}