using MelonLoader;

namespace SCH1ChatApp;

public class Core : MelonMod
{
    private int count = 1;
    
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg("Initialized.");
    }


    public override void OnEarlyInitializeMelon()
    {
        HelloWorld();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        Melon<Core>.Logger.Msg("COUNTER : " + count);
        count++;
    }

    public static void HelloWorld()
    {
        Melon<Core>.Logger.Msg("Hello World from a static method!");
    }
}