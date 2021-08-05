using UnityEditor;
using UnityEditor.SceneManagement;
public class PlaySceneLoader : EditorWindow
{
    [MenuItem("Play/PlaySceneStart %g")] // Unity Editor에 메뉴를 만든다. %p = Ctrl + g를 의미한다.

    public static void PlaySceneStart()
    {
        // Current Scene 이 수정되었을 시, 저장할 것인지 묻고, Paly한다.
        if (EditorSceneManager.GetActiveScene().isDirty)
        {
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        }

        EditorSceneManager.OpenScene("Assets/Scenes/Title.unity");
        EditorApplication.isPlaying = true;
    }
}
