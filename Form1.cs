namespace FileFinder
{
    public partial class Form1 : Form
    {
        string appFolder = Path.GetDirectoryName(Application.ExecutablePath);

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Defining processing folders
                string sourcePath = textBox1.Text;
                //string sortedPath = appFolder + @"\SortedLogs\";
                string snNumberFile = textBox2.Text;

                string destinationPath = txtBoxDestination.Text;

                // Read serial numbers from file



                string[] serialNumbers = File.ReadAllLines(snNumberFile);
                int snQuantity = serialNumbers.Length;
                int progrescounter = 0;
                int filecounter = 0;

                // For each of SN in file list we look for file in InputLogs folder and try to copy it
                if (Directory.Exists(sourcePath))
                {
                    DirectoryInfo source = new DirectoryInfo(sourcePath);
                    foreach (var item in serialNumbers)
                    {
                        if (item != string.Empty)
                        {
                            try
                            {
                                FileInfo[] filesinDir = source.GetFiles("*" + item + "*.*");
                                if (filesinDir.Length > 0)
                                {
                                    foreach (var file in filesinDir)
                                    {

                                        await Task.Run(() =>
                                        {
                                            file.CopyTo(txtBoxDestination.Text + "\\" + file.Name, true);
                                        });

                                        filecounter++;
                                    }
                                    progrescounter++;
                                    progressBar1.Value = progrescounter * 100 / snQuantity;

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error to find and move file");
                            }

                        }

                    }
                    MessageBox.Show($" For {snQuantity} serial numbers were copied {filecounter} logfiles");
                }
                else
                {
                    MessageBox.Show("No Source folder selected");
                }

            }
            else if (checkBox2.Checked) //Searching by SN text in file
            {
                // Defining processing folders
                string sourcePath = textBox1.Text;
                //string sortedPath = appFolder + @"\SortedLogs\";
                string snNumberFile = textBox2.Text;

                string destinationPath = txtBoxDestination.Text;

                // Read serial numbers from file

                string[] serialNumbers = File.ReadAllLines(snNumberFile);

                int snQuantity = serialNumbers.Length;
                int progrescounter = 0;
                int filecounter = 0;
                try
                {
                    DirectoryInfo source = new DirectoryInfo(sourcePath);

                    FileInfo[] filesInDir = source.GetFiles("*.*");

                    foreach (var item in filesInDir)
                    {
                        string data = string.Empty;

                        using (StreamReader reader = new StreamReader(item.FullName))
                        {
                            data = reader.ReadToEnd();

                            for (int i = 0; i < serialNumbers.Length; i++)
                            {
                                if (data.Contains(serialNumbers[i]))
                                {
                                    await Task.Run(() =>
                                    {
                                        item.CopyTo(txtBoxDestination.Text + "\\" + item.Name, true);
                                    });

                                    filecounter++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        progrescounter++;

                        progressBar1.Value = (progrescounter * 100) / filesInDir.Count();

                    }
                    MessageBox.Show($"for {serialNumbers.Length} serial numbers were copied {filecounter} files");
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = AppContext.BaseDirectory.ToString() + @"SN.txt";


        }

        private void btnBrowseLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBrowseSn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files | *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog.FileName;
            }

        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}