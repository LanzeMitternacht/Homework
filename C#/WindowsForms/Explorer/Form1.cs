using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Explorer
{
    public partial class Form1 : Form
    {
        private Stack<string> folderHistory = new Stack<string>();
        private string currentFolder;
        private string clipboardPath;

        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
            InitializeListView();
            InitializeContextMenu();
            InitializeAddressBar();
            currentFolder = DriveInfo.GetDrives().FirstOrDefault()?.Name;
            folderHistory.Push(currentFolder);
        }

        private void InitializeTreeView()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                TreeNode driveNode = CreateDriveNode(drive);
                TreeDisk.Nodes.Add(driveNode);
            }
        }
        private void InitializeListView()
        {
            LVFile.View = View.Details;
            LVFile.Columns.Add("Имя", 200);
            LVFile.Columns.Add("Размер", 100);
            LVFile.Columns.Add("Тип", 100);
        }
        private void InitializeContextMenu()
        {
            MenuItem openMenuItem = new MenuItem("Открыть", OpenMenuItem_Click);
            MenuItem exitMenuItem = new MenuItem("Выход", ExitMenuItem_Click);
            MenuItem refreshButton = new MenuItem("Обновить", RefreshButton_Click);

            MainMenu mainMenu = new MainMenu(new[] { openMenuItem, exitMenuItem, refreshButton});
            Menu = mainMenu;

            openMenuItem.Shortcut = Shortcut.CtrlO;
            exitMenuItem.Shortcut = Shortcut.CtrlX;
            refreshButton.Shortcut = Shortcut.CtrlY;
        }

        private void InitializeAddressBar()
        {
            TBAddress.TextChanged += TBAddress_TextChanged;

            Controls.Add(TBAddress);
        }

        private TreeNode CreateDriveNode(DriveInfo drive)
        {
            TreeNode driveNode = new TreeNode(drive.Name);
            driveNode.Tag = drive.Name;
            driveNode.Nodes.Add("Загрузка");

            return driveNode;
        }
        private TreeNode CreateDirectoryNode(string dir)
        {
            TreeNode node = new TreeNode(Path.GetFileName(dir));
            node.Tag = dir;
            node.Nodes.Add("Загрузка");

            return node;
        }
        private void PopulateTreeView(TreeNode parentNode)
        {
            try
            {
                if (Directory.Exists(parentNode.Tag.ToString()))
                {

                    string[] dirs = Directory.GetDirectories(parentNode.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        TreeNode node = CreateDirectoryNode(dir);
                        parentNode.Nodes.Add(node);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Нет доступа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void PopulateListView(string path)
        {
            LVFile.Items.Clear();

            try
            {
                PopulateItemsFromPath(Directory.GetDirectories(path), "Папка");
                PopulateItemsFromPath(Directory.GetFiles(path), "Файл");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Нет доступа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateItemsFromPath(string[] items, string itemType)
        {
            foreach (string itemPath in items)
            {
                string itemName = (itemType == "Папка") ? Path.GetFileName(itemPath) : Path.GetFileNameWithoutExtension(itemPath);

                ListViewItem item = new ListViewItem(itemName);
                item.SubItems.Add((itemType == "Файл") ? new FileInfo(itemPath).Length.ToString() : "");
                item.SubItems.Add(itemType);
                item.Tag = itemPath;

                LVFile.Items.Add(item);
            }
        }
        private void TBAddress_TextChanged(object sender, EventArgs e)
        {
            string newPath = TBAddress.Text;
            if (Directory.Exists(newPath))
            {
                currentFolder = newPath;
                folderHistory.Push(currentFolder);
                LoadFolder(currentFolder);
            }
        }
        private void TreeDisk_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "Загрузка")
            {
                e.Node.Nodes.Clear();
                PopulateTreeView(e.Node);
            }
        }

        private void TreeDisk_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "Загрузка")
            {
                e.Node.Nodes.Clear();
                PopulateTreeView(e.Node);
            }

            string selectedFolder = e.Node.Tag?.ToString();

            if (!string.IsNullOrEmpty(selectedFolder) && selectedFolder != currentFolder)
            {
                currentFolder = selectedFolder;
                folderHistory.Push(currentFolder);
                LoadFolder(currentFolder);
            }
        }
       
        private void LVFile_ItemActivate(object sender, EventArgs e)
        {
            if (LVFile.SelectedItems.Count > 0)
            {
                string selectedPath = LVFile.SelectedItems[0].Tag.ToString();
                if (Directory.Exists(selectedPath))
                {
                    PopulateListView(selectedPath);
                    TBAddress.Text = selectedPath;
                }
            }
        }
        private void LoadFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Выбранная папка не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            folderHistory.Push(folderPath);
            TBAddress.Text = folderPath;
            PopulateListView(folderPath);
        }

        private void FolderBrower()
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;

                    if (Directory.Exists(selectedFolder))
                    {
                        currentFolder = selectedFolder;
                        folderHistory.Push(currentFolder);
                        LoadFolder(currentFolder);

                        ExpandNodes(TreeDisk.Nodes, currentFolder);
                    }
                    else
                    {
                        MessageBox.Show("Выбранная папка не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExpandNodes(TreeNodeCollection nodes, string folderPath)
        {
            foreach (TreeNode node in nodes)
            {
                string nodePath = node.Tag?.ToString();

                if (!string.IsNullOrEmpty(nodePath) && folderPath.StartsWith(nodePath, StringComparison.OrdinalIgnoreCase))
                {
                    node.Expand();
                    ExpandNodes(node.Nodes, folderPath);
                }
            }
        }

        private void CopySelectedItem()
        {
            if (LVFile.SelectedItems.Count > 0)
            {
                clipboardPath = LVFile.SelectedItems[0].Tag.ToString();
            }
        }
        private void PasteItems()
        {
            if (!string.IsNullOrEmpty(clipboardPath) && Directory.Exists(currentFolder))
            {
                string fileName = Path.GetFileName(clipboardPath);
                string destinationPath = Path.Combine(currentFolder, fileName);

                int number = 1;
                while (File.Exists(destinationPath))
                {
                    string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{number}{Path.GetExtension(fileName)}";
                    destinationPath = Path.Combine(currentFolder, newFileName);
                    number++;
                }

                File.Copy(clipboardPath, destinationPath);
                LoadFolder(currentFolder);
            }
        }

        private void DeleteSelectedItem()
        {
            if (LVFile.SelectedItems.Count > 0)
            {
                string selectedPath = LVFile.SelectedItems[0].Tag.ToString();

                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить файл:\n{selectedPath}", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(selectedPath);
                        LoadFolder(currentFolder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                CopySelectedItem();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.V))
            {
                PasteItems();
                return true;
            }
            else if(keyData == Keys.Delete) 
            { 
                DeleteSelectedItem(); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BForward_Click(object sender, EventArgs e)
        {
            if (folderHistory.Count > 1)
            {
                string nextFolder = folderHistory.Pop();
                folderHistory.Push(currentFolder);
                currentFolder = nextFolder;
                LoadFolder(currentFolder);
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if (folderHistory.Count > 1)
            {
                folderHistory.Pop();
                string previousFolder = folderHistory.Pop();
                currentFolder = previousFolder;
                LoadFolder(currentFolder);
            }
            else { }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrower();
        }
        
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OpenConStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrower();
        }

        private void ExitConStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadFolder(currentFolder);
        }

        private void RefreshStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFolder(currentFolder);
        }
    }
}
