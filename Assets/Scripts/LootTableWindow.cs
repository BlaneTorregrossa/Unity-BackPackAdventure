//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.IO;
//using UnityEditor;

//public class LootTable : EditorWindow
//{
//    private GUIStyle Header = new GUIStyle();
//    public List<MainLootTable> tables = new List<MainLootTable>();
//    static string path;
//    public static List<string> allFiles;

//    [MenuItem("Tools/MainLootTableDatabase")]

//    static void init()
//    {
//        var window = EditorWindow.GetWindow(typeof(MainLootTable));
//        window.Show();
//        path = Application.dataPath + "/Resources/Tables/";
//        allFiles.AddRange(Directory.GetFiles(path));
//        foreach(var file in allFiles)
//        {
//            var relpath = file.Substring(path.Length - "Assets/Resources/Tables/".Length);
//            var table = AssetDatabase.LoadAssetAtPath<MainLootTable>(relpath);
//        }
//    }

//    private void GetGUI()
//    {
//        Header.alignment = TextAnchor.MiddleCenter;
//        Header.fontStyle = FontStyle.Bold;
//        Header.fontSize = 50;
//        Header.normal.textColor = Color.red;
//        GUILayout.Label("Words Words Words...", Header);
//        GUILayout.Space(25);
//        if (GUILayout.Button("Button This is..."))
//        { }
//        EditorGUILayout.TextField("This is a Path", path);
//    }

//}
