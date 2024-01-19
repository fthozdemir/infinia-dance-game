using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGrid
{
    void setPlayground(int index, bool value);
    void lightUp();
    void lightDown();
    void lightSuccess();
    void lightFail();
    void lightInitial();
    void Init();
    void Pressed();

}

