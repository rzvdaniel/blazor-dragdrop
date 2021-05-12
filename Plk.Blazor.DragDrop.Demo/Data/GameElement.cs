using System.Collections.Generic;

namespace Plk.Blazor.DragDrop.Demo.Data
{
    public class GameElement
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public bool Draggable { get; set; } = true;

        public GameElement(string Id, string Text, string Icon = null, bool Draggable = true)
        {
            this.Id = Id;
            this.Text = Text;
            this.Icon = Icon;
            this.Draggable = Draggable;
        }

        public List<GameElement> Items { get; set; } = new List<GameElement>();
    }
}
