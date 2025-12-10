using System;

namespace Features.Panel.StaticPanel.Exceptions
{
    public class PanelIdNotFound : Exception
    {
        public PanelIdNotFound(int id) : base(id.ToString())
        {
        }

        public PanelIdNotFound(string message) : base(message)
        {
        }

        public PanelIdNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}