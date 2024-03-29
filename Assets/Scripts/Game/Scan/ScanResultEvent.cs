﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModifiedLocation.Scripts.Game
{
    /// <summary>
    /// The player scan result type.
    /// </summary>
    public enum PlayerScanResultType
    {
        RESULT_SUCCESS,
        RESULT_LINE_UP,
        RESULT_FAILED,
        RESULT_ALREADY_FOUND
    }

    /// <summary>
    /// The literal player scan output.
    /// </summary>
    public struct PlayerScanResult
    {
        public PlayerScanResultType scanResult;
        public GameRiddle riddleFound;
        public GameRiddle nextRiddle;
    }

    /// <summary>
    /// Gets the output of a scan and sends an event.
    /// </summary>
    [CreateAssetMenu(fileName = "Scan Result Event", menuName = "Events/Scan Result Event")]
    public class ScanResultEvent : Utils.GenericEvent<PlayerScanResult> { }
}
