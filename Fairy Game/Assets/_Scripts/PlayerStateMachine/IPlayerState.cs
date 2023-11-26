using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState
{
    IPlayerState DoState(PlayerState player);
}
