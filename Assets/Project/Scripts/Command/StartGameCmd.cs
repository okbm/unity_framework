using UnityEngine;
using CleaveFramework.Commands;

// Analysis disable once CheckNamespace
class GameTypeConstructor
{
    public enum GameType {
        NewGame,
        LoadGame,
    };

    public GameType myType {get; private set;}
    public string GamaName {get; private set;}
    public int NumPlayers  {get; private set;}

    public GameTypeConstructor(GameType type, string name, int numPlayers)
    {
        myType = type;
        GamaName = name;
        NumPlayers = numPlayers;
    }
}

class StartGameCmd : Command {

    public GameTypeConstructor GameType {get; private set;}
    public StartGameCmd(GameTypeConstructor gameType)
    {
        GameType = gameType;
    }
}

/*
 * 何らかのviewクラス的なものに入れる予定
 * 
void StartNewGameButtonPressed()
{
    Framework.PushCommand(new StartGameCmd(new GameTypeConstructor(GameType.NewGame, "Awesome Game", 1)));
}
*/
