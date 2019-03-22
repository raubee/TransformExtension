using UnityEngine;

namespace TransformExtension
{
	public static class TransformExtension
	{
		public static Transform[] GetChildren(this Transform transform)
		{
			Transform[] children = new Transform[transform.childCount];

			for (int i = 0; i < transform.childCount; i++)
			{
				children[i] = transform.GetChild(i);
			}

			return children;
		}

		public static void Freeze(this Transform transform)
		{
			Transform[] children = transform.GetChildren();

			foreach (Transform child in children)
			{
				child.SetParent(null);
			}

			transform.position = Vector3.zero;
			transform.localScale = Vector3.one;
			transform.rotation = Quaternion.identity;

			foreach (Transform child in children)
			{
				child.SetParent(transform);
			}
		}
	}
}
