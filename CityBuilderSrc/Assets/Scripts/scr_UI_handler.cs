using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_UI_handler : MonoBehaviour
{
    public enum UIType
    {
        DEFAULT = 0,
        TRAIN = 1,
        TRAIN_CONNECT = 2
    }

    public static UIType CURRENT_UI = UIType.DEFAULT;
}
