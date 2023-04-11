using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EmployeeSystemWinform
{
    class CheckComboBox : ComboBox
    {
        public class ComboboxData
        {
            public string Data { get; set; }
            public bool Checked { get; set; }
            public int Id { get; set; }
            public ComboboxData(string value, bool ischeck, int id)
            {
                Data = value;
                Checked = ischeck;
                Id = id;
            }

            public override string ToString()
            {
                return Data;
            }

        }
        public event EventHandler Checkchanged;
        public CheckComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public List<ComboboxData> CheckItems
        {
            get
            {

                var newitems = new List<ComboboxData>();
                foreach (var item in Items)
                {
                    if (item is ComboboxData)
                    {
                        newitems.Add(item as ComboboxData);
                    }
                }
                return newitems;

            }
        }

        public List<ComboboxData> CheckedItem = new List<ComboboxData>();
        public string CheckedItemsText
        {
            get
            {

                var k = "";
                foreach (var item in CheckedItem)
                {
                    if (item is ComboboxData)
                    {
                        k+=$"{item},";
                    }
                }
                return k;

            }
        }
        protected override void OnLeave(EventArgs e)
        {
            this.Text = this.CheckedItemsText;
        }
        protected override void OnDropDown(EventArgs e)
        {
            this.Text = this.CheckedItemsText;
        }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            ComboboxData data = (ComboboxData)SelectedItem;
            data.Checked = !data.Checked;
            if (data.Checked == true)
            {
                CheckedItem.Add(data);
            }
            else
            {
                CheckedItem.Remove(data);

            }
            if (Checkchanged != null)
            {
                Checkchanged(data, e);
            }
            OnDropDownClosed(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }

            if (Items[e.Index] is ComboboxData)
            {
                ComboboxData data = Items[e.Index] as ComboboxData;
                CheckBoxRenderer.RenderMatchingApplicationState = true;
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.X, e.Bounds.Y), e.Bounds, data.Data, this.Font,
                    (e.State & DrawItemState.Focus) == 0, data.Checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
            }
            else
            {
                e.Graphics.DrawString(Items[e.Index].ToString(), this.Font, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
                return;
            }

            base.OnDrawItem(e);
        }

    }

}
