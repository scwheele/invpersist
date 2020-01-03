[ModTitle("Inventory Persist")] // The mod name.
[ModDescription("Keeps your inventory after death")] // Short description for the mod.
[ModAuthor("Scott")] // The author name of the mod.
[ModIconUrl("https://i.imgur.com/W6ekIRw.jpg")] // An icon for your mod. Its recommended to be 128x128px and in .jpg format.
[ModWallpaperUrl("https://i.imgur.com/jyxtOPF.jpg")] // A banner for your mod. Its recommended to be 330x100px and in .jpg format.
[ModVersionCheckUrl("https://www.raftmodding.com/api/v1/mods/invpersist/version.txt")] // This is for update checking. Needs to be a .txt file with the latest mod version.
[ModVersion("1.2")] // This is the mod version.
[RaftVersion("Update Name")] // This is the recommended raft version.
[ModIsPermanent(false)] // If your mod add new blocks, new items or just content you should set that to true. It loads the mod on start and prevents unloading.
public class InvPersist : Mod
{

    public override void WorldEvent_WorldLoaded()
    {
        GameModeValueManager.GetCurrentGameModeValue().playerSpecificVariables.clearInventoryOnSurrender = false;
    }
    
    public void Start()
    {
        RConsole.Log("InvPersist has been loaded!");
    }
    
    public void OnModUnload()
    {
        if (GameModeValueManager.GetCurrentGameModeValue().gameMode != GameMode.Easy)
        {
            GameModeValueManager.GetCurrentGameModeValue().playerSpecificVariables.clearInventoryOnSurrender = true;
        }
        RConsole.Log("InvPersist has been unloaded!");
        Destroy(gameObject); // Please do not remove that line!
    }
}
