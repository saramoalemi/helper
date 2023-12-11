using Asp.NetDevelopHelper.Model;
using Asp.NetDevelopHelper.Service;
using System.Configuration.Internal;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;

namespace Asp.NetDevelopHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            propertiesDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.txt"))
            {
                var path = File.ReadAllText("data.txt");

                prjPathTextbx.Text = path;
            }
            mainTabControl.SelectedIndex = 1;
        }



        public BaseModel CreateModel()
        {
            if (
                    string.IsNullOrWhiteSpace(tableTxbx.Text) ||
                    string.IsNullOrWhiteSpace(tableCaptionTxbx.Text) ||
                    string.IsNullOrWhiteSpace(schemaComboBox.Text) ||
                    string.IsNullOrWhiteSpace(keyTypeCombo.Text) ||
                    (hasYearCheckBox.Checked && string.IsNullOrWhiteSpace(yearTextBox.Text)))
            {
                throw new Exception("پر کردن همه فیلدها الزامی است");
            }
            if (hasYearCheckBox.Checked && (yearTextBox.Text.Contains("}") || yearTextBox.Text.Contains("{")))
                throw new Exception("سال مالی را درست وارد کن");

            var model = new BaseModel()
            {
                ProjectPath = Directory.GetParent(prjPathTextbx.Text).FullName,
                Table = tableTxbx.Text.Trim().ToUpper().Substring(0, 1) + tableTxbx.Text.Substring(1, tableTxbx.Text.Length - 1).ReplaceLineEndings(""),
                TableCaption = tableCaptionTxbx.Text.Trim().ReplaceLineEndings(""),
                Schema = schemaComboBox.Text.Trim().ToUpper().Substring(0, 1) + schemaComboBox.Text.Substring(1, schemaComboBox.Text.Length - 1).ReplaceLineEndings(""),
                Inherited = InheretedCheckBox.Checked,
                KeyType = keyTypeCombo.Text.Trim().ReplaceLineEndings(""),
                HasYear = hasYearCheckBox.Checked,
                YearName = yearTextBox.Text.Trim().ReplaceLineEndings(""),

                CreateModel = modelCreateCheck.Checked,
                CreateDto = dtoCreateCheck.Checked,
                CreateViewModel = viewModelCreateCheck.Checked,
                CreateMapping = mappingCreateCheck.Checked,
                CreateRepository = repositoryCreateCheck.Checked,
                CreateService = serviceCreateCheck.Checked,
                CreateController = controllerCreateCheck.Checked,
                CreateContextDbset = contextReferenceCreateCheck.Checked,
                CreateResources = resourceCreateCheck.Checked,
                CreateRelations = resourceCreateCheck.Checked,
            };
            foreach (DataGridViewRow item in propertiesDataGridView.Rows)
            {
                if (item.IsNewRow)
                    break;
                Property property = new Property()
                {
                    Name = item.Cells[0].Value.ToString().ReplaceLineEndings("").Trim(),
                    Type = item.Cells[2].Value?.ToString().ToLower().ReplaceLineEndings("").Trim(),
                    Required = bool.Parse(item.Cells[3].Value?.ToString() ?? "false"),
                    Maxlength = item.Cells[4].Value?.ToString().ReplaceLineEndings("").Trim(),
                    Minlength = item.Cells[5].Value?.ToString().ReplaceLineEndings("").Trim(),
                    Regex = item.Cells[6].Value?.ToString().ReplaceLineEndings("").Trim(),
                    IsKey = bool.Parse(item.Cells[8].Value?.ToString() ?? "false"),
                };
                model.Properties.Add(property);
                if (model.CreateResources)
                {
                    if (propertiesDataGridView.Rows.OfType<DataGridViewRow>().Any(x => !x.IsNewRow && x.Cells[1].Value == null))
                        throw new Exception("همه نام های فارسی ستون ها را وارد کنید");
                    model.Resources.Add(new Resource()
                    {
                        Name = item.Cells[0].Value.ToString().ReplaceLineEndings("").Trim(),
                        Value = item.Cells[1].Value.ToString().ReplaceLineEndings("").Trim(),
                    });
                }
            }

            var uniques = propertiesDataGridView.Rows.OfType<DataGridViewRow>()
                 .Select(x => new { name = x.Cells[0].Value?.ToString().ReplaceLineEndings(""), index = x.Cells[6].Value?.ToString() })
                 .Where(x => x.index != null).ToList();
            if (hasYearCheckBox.Checked && yearIndexTxbx.Text != "")
            {
                uniques.Add(new { name = "Year", index = yearIndexTxbx.Text });
            }
            if (uniques.Count > 0)
            {
                var res = string.Join(',', uniques.Select(x => x.index)).Split(',').Distinct().OrderBy(x => x).ToList();
                res.ForEach(x => model.UniqueIndexes.Add(uniques.Where(w => w.index.Contains(x)).Select(s => s.name).ToList()));
            }

            foreach (DataGridViewRow item in relationDataGridView.Rows)
            {
                if (item.IsNewRow)
                    break;
                Relation relation = new Relation()
                {
                    Schema = item.Cells[0].Value.ToString().ReplaceLineEndings("").Trim(),
                    Table = item.Cells[1].Value.ToString().ReplaceLineEndings("").Trim(),
                    PrincipalKey = item.Cells[2].Value?.ToString().ReplaceLineEndings("").Trim() ?? "ID",
                    ForeignKey = item.Cells[3].Value?.ToString().ReplaceLineEndings("").Trim() ?? "ID",
                    RelationType = (RelationType)Enum.Parse(typeof(RelationType), item.Cells[4].Value.ToString().ReplaceLineEndings("").Trim()),
                    IsSoftDelete = (bool)(item.Cells[6].Value ?? false),
                    IsSoftRelation = (bool)(item.Cells[7].Value ?? false)
                };
                model.Relations.Add(relation);
            }

            return model;
        }

        private void dataTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //???
        }



        private void openPrjPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Project File |*.sln";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                prjPathTextbx.Text = fileDialog.FileName;
                File.WriteAllText("Data.txt", fileDialog.FileName);

            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = propertiesDataGridView.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string[] lines = Clipboard.GetText().Split('\n').Where(x => x != "").ToArray();

                int row = propertiesDataGridView.CurrentCell.RowIndex;
                int col = propertiesDataGridView.CurrentCell.ColumnIndex;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] cells = lines[i].Split('\t');
                    //propertiesDataGridView.NewRowIndex
                    if (propertiesDataGridView.NewRowIndex == row + i)
                    {
                        DataGridViewRow newrow = new DataGridViewRow();
                        newrow.CreateCells(propertiesDataGridView);
                        for (int j = 0; j < cells.Length; j++)
                        {
                            newrow.Cells[j].Value = cells[j];
                            col++;
                        }
                        propertiesDataGridView.Rows.Add(newrow);
                    }

                    else
                        propertiesDataGridView[col, row + i].Value = lines[i];
                }

            }
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var model = CreateModel();
                if (model.Properties.Count == 0)
                    if (MessageBox.Show("هیچ پراپرتی به جدول اضافه نشده است. آیا مایل به ادامه هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;
                new ServiceCreator(model).CreateArvinService();
                MessageBox.Show("همه مراحل با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tableCaptionTxbx.Text = schemaComboBox.Text = tableCaptionTxbx.Text = yearIndexTxbx.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("همه تغییرات برگردانده شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            new ServiceCreator(CreateModel()).Revert();
            MessageBox.Show("همه مراحل با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Txbx_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Replace(" ", "");
        }

        private void prjPathTextbx_TextChanged(object sender, EventArgs e)
        {
            var parent = Directory.GetParent(prjPathTextbx.Text).FullName;
            schemaComboBox.Items.Clear();
            try
            {
                schemaComboBox.Items.AddRange(ServiceCreator.GetSchemas(parent).ToArray());
                (relationDataGridView.Columns[0] as DataGridViewComboBoxColumn).DataSource = schemaComboBox.Items;
            }
            catch (Exception)
            {

            }
            coreWebPathTxtBox.Text = parent + "\\ArvinERP.API";
            appPathTtextBox.Text = parent + "\\ArvinERP.Application";
            infraPathTxtBx.Text = parent + "\\ArvinERP.Infrastructure";
            domainPathTxtBx.Text = parent + "\\ArvinERP.Domain";
        }

        private void relationDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && relationDataGridView.CurrentRow?.Cells[0].Value != null)
            {
                var tabls = ServiceCreator.GetTables(Directory.GetParent(prjPathTextbx.Text).FullName, relationDataGridView.CurrentRow.Cells[0].Value.ToString());
                (relationDataGridView.CurrentRow.Cells[1] as DataGridViewComboBoxCell).DataSource = tabls;
                (relationDataGridView.CurrentRow.Cells[2] as DataGridViewComboBoxCell).Value = null;
            }
            if (e.ColumnIndex == 1 && relationDataGridView.CurrentRow?.Cells[1].Value != null)
            {
                var props = ServiceCreator.GetProperties(Directory.GetParent(prjPathTextbx.Text).FullName, relationDataGridView.CurrentRow.Cells[0].Value.ToString(), relationDataGridView.CurrentRow.Cells[1].Value.ToString());
                if (hasYearCheckBox.Checked)
                {
                    props.Insert(0, new Property() { Name = "Year" });
                }
                (relationDataGridView.CurrentRow.Cells[2] as DataGridViewComboBoxCell).Value = null;
                (relationDataGridView.CurrentRow.Cells[2] as DataGridViewComboBoxCell).DataSource = props;
                (relationDataGridView.CurrentRow.Cells[2] as DataGridViewComboBoxCell).DisplayMember = "Name";

            }
        }



        private void propertiesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (relationDataGridView.Columns.Count == 0)
                return;
            var list = propertiesDataGridView.Rows.OfType<DataGridViewRow>().Where(x => x.Index != -1)
              .Select(x => x.Cells[0].Value?.ToString()).Where(x => x != null).ToList();
            if (hasYearCheckBox.Checked)
            {
                list.Insert(0, "Year");
            }
            (relationDataGridView.Columns[3] as DataGridViewComboBoxColumn).DataSource = list;

        }
    }
}