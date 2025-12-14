namespace Features.Panel.Interfaces
{
    public interface IPanel<in TArgs>
    {
        void Show(TArgs args);
        void Hide();
    }
}