using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace XMLParser
{
    public partial class XMLForm : Form
    {

        static string XSLPATH = "../../../PhotoMetaData.xsl";
        static string HTMLPATH = "../../../PhotoMetaData.html";
        public XMLForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ProcessCloseFormClick(e);
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            ProcessOpenFileClick();
        }

        private void transformBtn_Click(object sender, EventArgs e)
        {
            ProcessTransformClick();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            resultsBox.Text = "";
            ProcessFindBtnClick();
        }

        private void ProcessCloseFormClick(FormClosingEventArgs e)
        {
            const string message = Constants.ConfirmExitMsg;
            const string caption = Constants.ConfirmExitHeader;
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void ProcessTransformClick()
        {
            if (Data.FilePath == null)
            {
                MessageBox.Show(Constants.NotChosenFileMsg);
                return;
            }

            var xct = new XslCompiledTransform();
            xct.Load(XSLPATH);
            xct.Transform(Data.FilePath, HTMLPATH);
            MessageBox.Show(Constants.TransformationSuccessMsg);
        }

        private void ProcessOpenFileClick()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.xml";
            openFileDialog.Title = "Оберіть файл для імпорту";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var nodes = Data.SetPath(openFileDialog.FileName);
            SetOptions(nodes);
        }

        private void SetOptions(XmlNodeList nodes)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes.Item(i);
                var author = node.SelectSingleNode("@Author");
                if (author != null && !authorBox.Items.Contains(author.Value))
                    authorBox.Items.Add(author.Value);

                var year = node.SelectSingleNode("@Year");
                if (year != null && !dateBox.Items.Contains(year.Value))
                    dateBox.Items.Add(year.Value);

                var city = node.SelectSingleNode("@City");
                if (city != null && !cityBox.Items.Contains(city.Value))
                    cityBox.Items.Add(city.Value);

                var size = node.SelectSingleNode("@Size");
                if (size != null && !sizeBox.Items.Contains(size.Value))
                    sizeBox.Items.Add(size.Value);

                var iso = node.SelectSingleNode("@ISO");
                if (iso != null && !isoBox.Items.Contains(iso.Value))
                    isoBox.Items.Add(iso.Value);

                var format = node.SelectSingleNode("@Format");
                if (format != null && !formatBox.Items.Contains(format.Value))
                    formatBox.Items.Add(format.Value);

                var quality = node.SelectSingleNode("@Quality");
                if (quality != null && !qualityBox.Items.Contains(quality.Value))
                    qualityBox.Items.Add(quality.Value);
            }
        }

        private void SetAuthor()
        {
            if (authorCheckBox.Checked && authorBox.Text.Length > 0)
                Data.SearchTarget.Author = authorBox.Text;
            if (!authorCheckBox.Checked)
                Data.SearchTarget.Author = null;
        }

        private void SetYear()
        {
            if (dateCheckBox.Checked && dateBox.Text.Length > 0)
            {
                try
                {
                    Data.SearchTarget.Year = Int32.Parse(dateBox.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Constants.WrongYear);
                    dateBox.Text = "";
                }
            }
            if (!dateCheckBox.Checked)
                Data.SearchTarget.Year = null;
        }

        private void SetCity()
        {
            if (cityCheckBox.Checked && cityBox.Text.Length > 0)
                Data.SearchTarget.City = cityBox.Text;
            if (!cityCheckBox.Checked)
                Data.SearchTarget.City = null;
        }

        private void SetSize()
        {
            if (sizeCheckBox.Checked && sizeBox.Text.Length > 0)
            {
                try
                {
                    Data.SearchTarget.Size = Int32.Parse(sizeBox.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Constants.WrongSize);
                    sizeBox.Text = "";
                }
            }
            if (!sizeCheckBox.Checked)
                Data.SearchTarget.Size = null;
        }

        private void SetISO()
        {
            if (isoCheckBox.Checked && isoBox.Text.Length > 0)
            {
                try
                {
                    Data.SearchTarget.ISO = Int32.Parse(isoBox.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Constants.WrongISO);
                    isoBox.Text = "";
                }
            }
            if (!isoCheckBox.Checked)
                Data.SearchTarget.ISO = null;
        }

        private void SetFormat()
        {
            if (formatCheckBox.Checked && formatBox.Text.Length > 0)
                Data.SearchTarget.Format = formatBox.Text;
            if (!formatCheckBox.Checked)
                Data.SearchTarget.Format = null;
        }

        private void SetQuality()
        {
            if (qualityCheckBox.Checked && qualityBox.Text.Length > 0)
                Data.SearchTarget.Quality = Utils.ParseToQuality(qualityBox.Text);
            if (!qualityCheckBox.Checked)
                Data.SearchTarget.Quality = null;
        }

        private void ProcessFindBtnClick()
        {
            if(Data.FilePath == null)
            {
                MessageBox.Show(Constants.NotChosenFileMsg);
                return;
            }

            SetTargetObject();

            var strategy = ChooseSearchStrategy();
            if (strategy == null) return;

            var result = strategy.Search(Data.SearchTarget);
            foreach(var photo in result)
            {
                resultsBox.Text += photo.ToString();
            }
        }

        private void SetTargetObject()
        {
            SetAuthor();
            SetCity();
            SetYear();
            SetSize();
            SetCity();
            SetISO();
            SetFormat();
            SetQuality();
        }

        private IXMLSearchStrategy ChooseSearchStrategy()
        {
            if (domBtn.Checked)
            {
                return new DomXMLSearchStrategy();
            }
            else if (saxBtn.Checked)
            {
                return new SaxXMLSearchStrategy();
            }
            else if (linqBtn.Checked)
            {
                return new LinqXMLSearchStrategy();
            }
            MessageBox.Show(Constants.NotChosenMsg);
            return null;
        }

    }
}
