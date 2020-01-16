using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

[CustomEditor(typeof(achievementDatabase))]
public class AchievementDatabaseEditor : Editor
{
    private achievementDatabase database;
    private void OnEnable()
    {
        database = target as achievementDatabase;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Generate Enum", GUILayout.Height(30)))
        {
            GenerateEnum();
        }
    }

    private void GenerateEnum()
    {
        string filePath = Path.Combine(Application.dataPath, "Achievements.cs");
        String code = "public enum Achievements {";
        foreach(achievement achievement in database.achievements)
        {
            code += achievement.id + ",";
        }
        code += "}";
        File.WriteAllText(filePath, code);
        AssetDatabase.ImportAsset("Assets/Achievements.cs");
    }
}
