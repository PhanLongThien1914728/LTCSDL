using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungDocBao
{
    public partial class AddNewFeeds : Form
    {
        private readonly NewsFeedManager _newsManager;
        public bool HasChanges { get; set; }
        public AddNewFeeds(NewsFeedManager newsManager)
        {
            _newsManager = newsManager;
            InitializeComponent();
        }

        private void AddNewFeeds_Load(object sender, EventArgs e)
        {
            var publishers = _newsManager.GetNewsFeed();
            foreach (var publisher in publishers)
            {
                cbbToaSoan.Items.Add(publisher.Name);
            }
        }


        private void ClearForm()
        {
            cbbToaSoan.Text = "";
            txtTenChuyenMuc.Text = "";
            txtRssLink.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                var pulishName = cbbToaSoan.Text;
                var categoryName = txtTenChuyenMuc.Text;
                var rssLink = txtRssLink.Text;

                if (string.IsNullOrWhiteSpace(pulishName) ||
                    string.IsNullOrWhiteSpace(categoryName) ||
                    string.IsNullOrWhiteSpace(rssLink))
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu!", "Error");
                    return;
                }

                HasChanges = true;

                var success = _newsManager.AddCategory(pulishName, categoryName, rssLink, false);
                if (success)
                {
                    ClearForm();
                    return;
                }

                if (MessageBox.Show("Chuyên mục này đã tồn tại, bạn có muốn cập nhật RSS Link không??", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _newsManager.AddCategory(pulishName, categoryName, rssLink, true);
                }

                ClearForm();
            }
        }
    }
}
