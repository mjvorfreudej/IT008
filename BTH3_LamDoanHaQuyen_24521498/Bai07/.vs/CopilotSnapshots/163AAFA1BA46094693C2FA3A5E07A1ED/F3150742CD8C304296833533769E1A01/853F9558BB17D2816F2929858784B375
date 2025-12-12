using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    public partial class MainForm : Form
    {
        const float BASE_DPI = 96f;

        static readonly Color ColorAvailable = Color.White;
        static readonly Color ColorSelected = Color.RoyalBlue;
        static readonly Color ColorSold = Color.Yellow;

        readonly int[] ROW_PRICE = { 5000, 6500, 8000 };

        const int SEAT_W = 90;
        const int SEAT_H = 70;
        const int SEAT_GAP = 16;

        private Dictionary<int, Button> seatButtons = new Dictionary<int, Button>();

        public MainForm()
        {
            InitializeComponent();
            BuildSeats();
        }

        private void BuildSeats()
        {
            int n = 1;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    var btn = new Button
                    {
                        Text = n.ToString(),
                        BackColor = ColorAvailable,
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Standard,
                        Margin = new Padding(0, 0, c == 4 ? 0 : SEAT_GAP, r == 2 ? 0 : SEAT_GAP),
                        Size = new Size(SEAT_W, SEAT_H),
                        MinimumSize = new Size(SEAT_W, SEAT_H),
                        MaximumSize = new Size(SEAT_W, SEAT_H),
                        Tag = new SeatInfo { Number = n, RowIndex = r, State = SeatState.Available }
                    };
                    btn.Click += Seat_Click;

                    seatsGrid.Controls.Add(btn, c, r);
                    seatButtons[n] = btn;
                    n++;
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SeatInfo info = (SeatInfo)btn.Tag;

            if (info.State == SeatState.Sold)
            {
                MessageBox.Show("Vị trí ghế " + info.Number + " đã được bán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (info.State == SeatState.Available)
            {
                info.State = SeatState.Selected;
                btn.BackColor = ColorSelected;
                btn.ForeColor = Color.White;
            }
            else
            {
                info.State = SeatState.Available;
                btn.BackColor = ColorAvailable;
                btn.ForeColor = Color.Black;
            }

            btn.Tag = info;
            UpdatePreviewMoney();
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Button btn in seatButtons.Values)
            {
                SeatInfo info = (SeatInfo)btn.Tag;
                if (info.State == SeatState.Selected)
                {
                    info.State = SeatState.Sold;
                    btn.Tag = info;
                    btn.BackColor = ColorSold;
                    btn.ForeColor = Color.Black;
                    total += ROW_PRICE[info.RowIndex];
                }
            }
            txtThanhTien.Text = total.ToString();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in seatButtons.Values)
            {
                SeatInfo info = (SeatInfo)btn.Tag;
                if (info.State == SeatState.Selected)
                {
                    info.State = SeatState.Available;
                    btn.Tag = info;
                    btn.BackColor = ColorAvailable;
                    btn.ForeColor = Color.Black;
                }
            }
            txtThanhTien.Text = "0";
        }

        private void UpdatePreviewMoney()
        {
            int preview = 0;
            foreach (Button btn in seatButtons.Values)
            {
                SeatInfo info = (SeatInfo)btn.Tag;
                if (info.State == SeatState.Selected)
                    preview += ROW_PRICE[info.RowIndex];
            }
            txtThanhTien.Text = preview.ToString();
        }

        private struct SeatInfo
        {
            public int Number;
            public int RowIndex;
            public SeatState State;
        }
        private enum SeatState { Available, Selected, Sold }
    }
}