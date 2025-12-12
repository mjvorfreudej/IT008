using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Bai08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateTotal();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string amountText = txtAmount.Text.Trim();

            if (string.IsNullOrEmpty(account) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal amount))
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = lvAccounts.Items.Cast<ListViewItem>()
                .FirstOrDefault(it => string.Equals(it.SubItems[1].Text, account, StringComparison.OrdinalIgnoreCase));

            if (existing == null)
            {
                var item = new ListViewItem((lvAccounts.Items.Count + 1).ToString());
                item.SubItems.Add(account);
                item.SubItems.Add(name);
                item.SubItems.Add(address);
                item.SubItems.Add(amount.ToString("N0", CultureInfo.CurrentCulture));

                lvAccounts.Items.Add(item);
                RefreshStt();
                UpdateTotal();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {
                existing.SubItems[2].Text = name;
                existing.SubItems[3].Text = address;
                existing.SubItems[4].Text = amount.ToString("N0", CultureInfo.CurrentCulture);
                UpdateTotal();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string accountToDelete = txtAccount.Text.Trim();
            if (string.IsNullOrEmpty(accountToDelete))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = lvAccounts.Items.Cast<ListViewItem>()
                .FirstOrDefault(it => string.Equals(it.SubItems[1].Text, accountToDelete, StringComparison.OrdinalIgnoreCase));

            if (item == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dr = MessageBox.Show($"Bạn có muốn xóa tài khoản {accountToDelete}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lvAccounts.Items.Remove(item);
                RefreshStt();
                UpdateTotal();
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void lvAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAccounts.SelectedItems.Count == 0)
                return;

            var it = lvAccounts.SelectedItems[0];
            txtAccount.Text = it.SubItems[1].Text;
            txtName.Text = it.SubItems[2].Text;
            txtAddress.Text = it.SubItems[3].Text;
            txtAmount.Text = it.SubItems[4].Text.Replace(",", "");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateTotal()
        {
            decimal total = 0m;
            foreach (ListViewItem it in lvAccounts.Items)
            {
                if (decimal.TryParse(it.SubItems[4].Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal v))
                    total += v;
            }
            txtTotal.Text = total.ToString("N0", CultureInfo.CurrentCulture);
        }

        private void RefreshStt()
        {
            for (int i = 0; i < lvAccounts.Items.Count; i++)
            {
                lvAccounts.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void ClearInputs()
        {
            txtAccount.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtAmount.Clear();
            txtAccount.Focus();
        }
    }
}