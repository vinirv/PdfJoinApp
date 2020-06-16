using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        private static List<string> listaArquivos = new List<string>();

        private static string pastaInicial = string.Empty;
        private static string desktop = string.Empty;

        public Home()
        {
            InitializeComponent();

            pastaInicial = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DataBinding();
        }

        private void DataBinding()
        {
            listBox.DataSource = null;
            listBox.DataSource = listaArquivos;
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                FileName = "",
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Select files",
                InitialDirectory = pastaInicial,
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFiles = openFileDialog.FileNames;
                pastaInicial = Path.GetDirectoryName(selectedFiles[0]);

                listaArquivos.AddRange(selectedFiles.ToList());

                DataBinding();
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog()
            {
                FileName = "documento.pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Selecionar PDfs",
                InitialDirectory = pastaInicial
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var saveFile = saveFileDialog.FileName;
                tbxDestino.Text = saveFile;

                pastaInicial = Path.GetDirectoryName(saveFile);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var pdfMerger = new PdfUtils.PdfMerge();

                pdfMerger.AddList(listaArquivos);
                pdfMerger.Save(tbxDestino.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO! Mensagem: {ex.Message}",
                                "ERRO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                return;
            }

            MessageBox.Show("Processo executado com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var indiceParaRemover = listBox.SelectedIndex;

            listaArquivos.RemoveAt(indiceParaRemover);

            DataBinding();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoverItem(listaArquivos, listBox.SelectedIndex, "up");
        }

        private void MoverItem(List<string> listaArquivos, int oldIndex, string operacao)
        {
            if (oldIndex < 0) return;

            var newIndex = oldIndex;
            var item = listaArquivos[oldIndex];
            var maxIndex = listaArquivos.Count - 1;

            if (operacao == "up" && oldIndex > 0)
            {
                listaArquivos.RemoveAt(oldIndex);

                newIndex--;
                listaArquivos.Insert(newIndex, item);
            }
            if (operacao == "down" && oldIndex < maxIndex)
            {
                listaArquivos.RemoveAt(oldIndex);

                newIndex++;
                listaArquivos.Insert(newIndex, item);
            }

            DataBinding();
            listBox.SelectedIndex = newIndex;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoverItem(listaArquivos, listBox.SelectedIndex, "down");
        }
    }
}
