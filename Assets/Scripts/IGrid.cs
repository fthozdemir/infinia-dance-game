using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGrid
{
    void SetPlayground(int index, bool value);
    void LightUp();
    void LightDown();
    void LightSuccess();
    void LightFail();
    void LightInitial();
    void Init();
    void Pressed();

}

