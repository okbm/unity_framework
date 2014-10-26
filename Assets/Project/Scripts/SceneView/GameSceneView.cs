using UnityEngine;
using System.Collections;
using CleaveFramework.Scene;
using CleaveFramework.Core;

class GameSceneView : SceneView {

    public override void Initialize()
    {
        var gameConstructModel = Framework.Globals.ResolveSingleton<GameTypeConstructor> () as GameTypeConstructor;

        switch(gameConstructModel.myType)
        {
            case GameTypeConstructor.GameType.NewGame:
                var numPlayers = gameConstructModel.NumPlayers;
                // etc
                break;
            case GameTypeConstructor.GameType.LoadGame:
                // loadring game
                break;
        }
    }
}
