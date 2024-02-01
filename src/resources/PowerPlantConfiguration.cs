using Godot;

[GlobalClass]
public partial class PowerPlantConfiguration : BaseComponent
{

    [Export]
    private int production;

    [Export]
    private int size;

    public int GetProduction()
    {
        return production;
    }

    public int GetSize()
    {
        return size;
    }
}
