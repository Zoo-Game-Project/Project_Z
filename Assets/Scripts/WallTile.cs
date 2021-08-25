using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DesignTile : Tile
{

#if UNITY_EDITOR
    [MenuItem("Assets/Create/Tiles/DesignTile")]
    public static void CreateWaterTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save DesignTile", "New DesignTile", "asset", "Save DesignTile", "Assets");
        if (path == "")
        {
            return;
        }
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<DesignTile>(), path);
    }

#endif
} // WallTile
