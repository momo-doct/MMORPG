using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceUtil  {

    /// <summary> 设备标识符 </summary>
    public static string DeviceIdentifier
    {
        get
        {
            return SystemInfo.deviceUniqueIdentifier;
        }
    }

    /// <summary> 获取设备型号 </summary>
    public static string DeviceModel
    {
        get
        {
#if UNITY_IPHONE && !UNITY_EDITOR
            return UnityEngine.iOS.Device.generation.ToString();
#else
            return SystemInfo.deviceModel;
#endif

        }
    }
}