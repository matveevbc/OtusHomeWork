namespace Lessons.Gameplay.Mech
{
    public interface IStoneLoadZoneComponent
    {
        bool CanLoad();

        void Load(int resources);
    }
}