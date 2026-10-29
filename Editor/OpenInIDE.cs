using UnityEditor;
using UnityEditorInternal;

namespace Yeahrik.DevTools.Editor
{
    public static class OpenInIDE
    {
        [MenuItem("Assets/Open in VS Code", false, 20)]
        private static void OpenSelectedAssetInIDE()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (!string.IsNullOrEmpty(path))
            {
                InternalEditorUtility.OpenFileAtLineExternal(path, 1);
            }
        }

        [MenuItem("Assets/Open in VS Code", true)]
        private static bool ValidateOpenSelectedAssetInIDE()
        {
            return Selection.activeObject != null;
        }
    }
}