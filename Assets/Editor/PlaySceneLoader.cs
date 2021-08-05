using UnityEditor;
using UnityEditor.SceneManagement;
public class PlaySceneLoader : EditorWindow
{
    [MenuItem("Play/PlaySceneStart %g")] // Unity Editor�� �޴��� �����. %p = Ctrl + g�� �ǹ��Ѵ�.

    public static void PlaySceneStart()
    {
        // Current Scene �� �����Ǿ��� ��, ������ ������ ����, Paly�Ѵ�.
        if (EditorSceneManager.GetActiveScene().isDirty)
        {
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        }

        EditorSceneManager.OpenScene("Assets/Scenes/Title.unity");
        EditorApplication.isPlaying = true;
    }
}
