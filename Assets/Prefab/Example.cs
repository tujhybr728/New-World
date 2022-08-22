using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private Vector2 scrollViewVector = Vector2.zero;
    private string innerText = "I am inside the ScrollView";
    public float hSliderValue = 0.0f;

    //void OnGUI()
    //{
    //    scrollViewVector = GUI.BeginScrollView(new Rect(25, 25, 100, 100),
    //    scrollViewVector, new Rect(0, 0, 400, 400));
    //    innerText = GUI.TextArea(new Rect(0, 0, 400, 400), innerText);
    //    GUI.EndScrollView();
    //}

    // Start is called before the first frame update
    private Rect windowRect = new Rect(0, 0, 180, 175);
    private Rect windowSlayder = new Rect(200, 200, 180, 175);
    void OnGUI()
    {
        windowRect = GUI.Window(0, windowRect, WindowFunction, "Pause");
        windowSlayder = GUI.Window(1, windowSlayder, Slidercontroler, "Slide");
    }
    void WindowFunction(int windowID)
    {
        if (GUI.Button(new Rect(0, 30, 160, 30),
        "Continue"))
            print("Continue");
        if (GUI.Button(new Rect(0, 65, 160, 30),
        "Restart"))
            print("Restart");
        if (GUI.Button(new Rect(0, 100, 160, 30),
        "Settings"))
            print("Settings");
        if (GUI.Button(new Rect(0, 135, 160, 30),
        "Exit"))
            print("Exit");
    }

    void Slidercontroler (int windowID)
    {
        hSliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), hSliderValue, 0.0f, 10.0f);
    }

}
