namespace Lessons.Gameplay.Mech
{
    public interface IWoodLoadZoneComponent
    {
        bool CanLoad();

        void Load(int resources);
    }
}