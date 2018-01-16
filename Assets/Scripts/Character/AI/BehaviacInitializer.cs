using behaviac;
using UnityEngine;
public class BehaviacInitializer
{

    private static bool isBehaviacInited = false;
    public static bool InitBehavic()
    {
        behaviac.Debug.LogWarning("InitBehavic");

        behaviac.Workspace.Instance.FilePath = ExportedFilePath;
        behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

        return true;
    }
    private static string ExportedFilePath
    {
        get
        {
            string relativePath = "/Resources/behaviac/exported";

            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                return Application.dataPath + relativePath;
            }
            else if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                return Application.dataPath + relativePath;
            }
            else
            {
                return "Assets" + relativePath;
            }
        }
    }

}