using UnityEditor;
using UnityEngine;

namespace TransformExtension.Editor
{
	public static class TransformExtensionEditor
	{
		[MenuItem("CONTEXT/Transform/Freeze")]
		static void FreezeMenu(MenuCommand command)
		{
			Transform transform = (Transform)command.context;
			Object[] toRecord = new Object[transform.childCount + 1];
			toRecord[0] = transform;

			for (int i = 0; i < transform.childCount; i++)
			{
				toRecord[i + 1] = transform.GetChild(i);
			}

			Undo.RecordObjects(toRecord, "Freeze");
			transform.Freeze();
		}
	}
}
