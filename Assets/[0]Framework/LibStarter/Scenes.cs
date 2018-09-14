namespace Homebrew
{
    [System.Flags]
    public enum Scenes
    {
     
        sceneGame = 0,
        sceneCamera = 1,
        sceneKernel = 2
    }

    public static partial class Game
    {
        public static void To(Scenes scene)
        {
            ProcessingSceneLoad.To((int) scene);
        }

        public static void Add(Scenes scene)
        {
            ProcessingSceneLoad.Add((int) scene);
        }

        public static void Remove(Scenes scene)
        {
            ProcessingSceneLoad.Remove((int) scene);
        }
    }
}