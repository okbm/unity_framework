using CleaveFramework.Scene;
using CleaveFramework.Commands;
using CleaveFramework.Core;

class MainMenuSceneView : SceneView {

    public override void Initialize()
    {
        CmdBinder.AddBinding<StartGameCmd> (OnStartGame);
    }

    void OnDestory()
    {
        CmdBinder.RemoveBinding<StartGameCmd> (OnStartGame);
    }

    void OnStartGame(Command c)
    {
        StartGameCmd cmd = c as StartGameCmd;
        Framework.Globals.PushSingleton<GameTypeConstructor> (cmd.GetType);

        Framework.PushCommand(new ChangeSceneCmd("Game"));
    }
}
