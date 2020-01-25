﻿using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkTesting : MonoBehaviour
{
    public TextAsset InkJSON;//allows Unity and the user to attach and access Ink files created in the Inky editor.

    private Story story;
    // Start is called before the first frame update
    void Start()
    {
        story = new Story(InkJSON.text);
        Debug.Log(LoadStoryChunk());

        for(int i=0; i< story.currentChoices.Count; i++)
        {
            Debug.Log(story.currentChoices[i].text);
        }
        story.ChooseChoiceIndex(0);

        Debug.Log(LoadStoryChunk());
        Debug.Log(LoadStoryChunk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string LoadStoryChunk()
    {
        string text = "";
        if(story.canContinue)
        {
           text= story.ContinueMaximally();
        }
        return text;
    }
}
