using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Commands
{
    public interface ICommand
    {
        string LabelText { get; }

        void SetDataGridView(DataGridView dgv);
        void Load();
        void Search(string keyword);
        void Insert();
        void Edit();
        void Delete();
        Dictionary<string, string> FormatMap { get; }
    }
}
