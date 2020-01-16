using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public achievementDatabase database;

    public achievementNotificationController achievementNotificationController;

    public Achievements achievementToShow;

    public void ShowNotification()
    {
        achievement achievement = database.achievements[(int)achievementToShow];
        achievementNotificationController.ShowNotification(achievement);
    }
    
}
