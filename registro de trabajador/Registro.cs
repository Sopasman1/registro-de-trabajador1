using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using world=Xceed.Document.NET;
using Xceed.Words.NET;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Xceed.Document.NET;
using Document = iTextSharp.text.Document;
using Formatting = Newtonsoft.Json.Formatting;
using System.Diagnostics;
using System.Text.RegularExpressions;
namespace registro_de_trabajador
{
    public partial class Registro : Form
    {
        public Registro()
        {

            InitializeComponent();
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha de nacimiento seleccionada
            DateTime fechaNacimiento = dateTimePicker1.Value;
            // Calcular la edad
            int edad = CalcularEdad(fechaNacimiento);
            // Mostrar la edad en un Label
            labelEdad.Text = ": " + edad.ToString();
        }
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            // Ajustar si no ha cumplido años este año
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        private void Nombretext_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número
            if (char.IsDigit(e.KeyChar))
            {
                // Cancela el evento si es un número
                e.Handled = true;
            }

        }

        private void apellidotext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void apellidomtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edadtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void phonetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float quincena = 15;
            string email = emailtext.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si el correo no es válido
            }

            string curp = curptext.Text;
            if (!IsValidCurp(curp))
            {
                MessageBox.Show("Por favor, ingrese una CURP válida.", "CURP inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si la CURP no es válida
            }

            string rfc = rfctext.Text;
            if (!IsValidRfc(rfc))
            {
                MessageBox.Show("Por favor, ingrese un RFC válido.", "RFC inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si el RFC no es válido
            }

            string phone = phonetext.Text;
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Por favor, ingrese un número telefónico válido.", "Número telefónico inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si el número telefónico no es válido
            }

            Datos_de_persona datosp = new Datos_de_persona();
            datosp.Nombre = Nombretext.Text;
            datosp.ApellidoPaterno = apellidotext.Text;
            datosp.Apellidomaterno = apellidomtext.Text;
            datosp.Cumple = dateTimePicker1.Value;
            

            Datos_de_registro datosr = new Datos_de_registro();
            datosr.Curp = curptext.Text;
            datosr.Rfc = rfctext.Text;
            datosr.Correo = emailtext.Text;
            datosr.Phone = phonetext.Text;

            DataGridViewRow load = new DataGridViewRow();
            load.CreateCells(Datosdetrabajadores);
            load.Cells[0].Value = Nombretext.Text;
            load.Cells[1].Value = apellidotext.Text;
            load.Cells[2].Value = apellidomtext.Text;
            load.Cells[3].Value = dateTimePicker1.Text;
            load.Cells[4].Value = labelEdad.Text;
            load.Cells[5].Value = curptext.Text;
            load.Cells[6].Value = rfctext.Text;
            load.Cells[7].Value = emailtext.Text;
            load.Cells[8].Value = phonetext.Text;
            load.Cells[9].Value = comboBox1.Text;
            load.Cells[10].Value = label3.Text;
            load.Cells[11].Value = label4.Text;
            load.Cells[12].Value = (float.Parse(label13.Text) * quincena - float.Parse(label14.Text));
            Datosdetrabajadores.Rows.Add(load);
            Nombretext.Text = apellidotext.Text = apellidomtext.Text = dateTimePicker1.Text = curptext.Text = rfctext.Text = emailtext.Text = phonetext.Text = comboBox1.Text =label3.Text=label14.Text = "";

        }
        private bool IsValidEmail(string email)
        {
            // Expresión regular para validar el correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidCurp(string curp)
        {
            // Expresión regular para validar la CURP (18 caracteres alfanuméricos específicos)
            string pattern = @"^[A-Z]{4}\d{6}[HM][A-Z]{5}[A-Z0-9]{2}$";
            return Regex.IsMatch(curp, pattern);
        }

        private bool IsValidRfc(string rfc)
        {
            // Expresión regular para validar el RFC (13 caracteres para personas físicas)
            string pattern = @"^[A-ZÑ&]{3,4}\d{6}[A-Z\d]{3}$";
            return Regex.IsMatch(rfc, pattern);
        }

        private bool IsValidPhone(string phone)
        {
            // Expresión regular para validar el número telefónico (10 dígitos)
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phone, pattern);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float sueldo;
            float isr;
            sueldo = comboBox1.SelectedIndex;
            isr = comboBox1.SelectedIndex;
            switch (sueldo)
            {
                case 0: label13.Text = "400"; break;
                case 1: label13.Text = "300"; break;
                default: label13.Text = "250"; break;

            }
            switch(isr)
            {
                case 0:label14.Text = "350"; break;
                case 1:label14.Text = "280"; break;
                default:label14.Text = "150"; break;
            }

        }


        private void Registro_Load(object sender, EventArgs e)
        {

            string filePath = @"D:\registro de trabajador\Trabajadores\documento.txt";


            if (File.Exists(filePath))
            {
                try
                {
                    // Leer el archivo y cargar los datos en el DataGridView
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Datosdetrabajadores.Rows.Add(line.Split('\t'));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al leer el archivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string filePath = @"D:\registro de trabajador\Trabajadores\documento.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in Datosdetrabajadores.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join("\t", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "").ToArray());
                        writer.WriteLine(line);
                    }
                }
            }

            MessageBox.Show("Datos guardados correctamente.");
        }

        private void borrarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Eliminar empleado",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    Datosdetrabajadores.Rows.Remove(Datosdetrabajadores.CurrentRow);

                }

            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivo Excel (*.xlsx)|*.xlsx|Archivo PDF (*.pdf)|*.pdf|Documento de World (*.docx)|*.docx|Archivos json (*.json)|*.json";
            saveFileDialog1.Title = "Guardar como archivo";
            saveFileDialog1.ShowDialog();

            // Si se selecciona un archivo y se confirma la selección
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;

                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        ExportarAExcel(fileName);
                    }
                    
                    else if (saveFileDialog1.FilterIndex == 2)
                    {
                        ExportarAPDF(fileName);
                    }
                    else if(saveFileDialog1.FilterIndex == 3)
                    {
                        ExportarAWord(fileName);
                    }
                    else if ((saveFileDialog1.FilterIndex == 4))
                    {
                        ExportarAPDF(fileName);
                    }


                    MessageBox.Show("Los datos se exportaron correctamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

        private void ExportarAExcel(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Crea un nuevo libro de Excel
            Workbook workbook = excelApp.Workbooks.Add();

            // Obtiene la primera hoja de trabajo del libro
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            // Escribe los datos del DataGridView en la hoja de trabajo
            for (int i = 0; i < Datosdetrabajadores.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = Datosdetrabajadores.Columns[i].HeaderText;
            }

            for (int i = 0; i < Datosdetrabajadores.Rows.Count; i++)
            {
                for (int j = 0; j < Datosdetrabajadores.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Datosdetrabajadores.Rows[i].Cells[j].Value;
                }
            }

            // Guarda el libro en un archivo
            workbook.SaveAs(fileName);
  
            // Cierra el libro y Excel
            workbook.Close();
            excelApp.Quit();
            Process.Start(new ProcessStartInfo(fileName) { UseShellExecute=true });
        }

       

        private void ExportarAPDF(string fileName)
        {

            // Crear un nuevo documento PDF
            Document doc = new Document();

            // Crear un objeto PdfWriter para escribir en el archivo PDF
            PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));

            // Abrir el documento para escribir en él
            doc.Open();

            // Agregar un párrafo al documento
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph("Datos exportados desde DataGridView:");
            doc.Add(paragraph);

            // Crear una tabla con el mismo número de columnas que el DataGridView
            PdfPTable table = new PdfPTable(Datosdetrabajadores.Columns.Count);

            // Agregar encabezados de columnas a la tabla
            for (int i = 0; i < Datosdetrabajadores.Columns.Count; i++)
            {
                table.AddCell(new Phrase(Datosdetrabajadores.Columns[i].HeaderText));
            }

            // Agregar datos de celdas a la tabla
            for (int i = 0; i < Datosdetrabajadores.Rows.Count; i++)
            {
                for (int j = 0; j < Datosdetrabajadores.Columns.Count; j++)
                {
                    if (Datosdetrabajadores.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new Phrase(Datosdetrabajadores.Rows[i].Cells[j].Value.ToString()));
                    }
                    else
                    {
                        table.AddCell(new Phrase(""));
                    }
                }
            }
           
            // Agregar la tabla al documento
            doc.Add(table);
            doc.Close();
            Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });
      
        }
        private void ExportarAWord(string filename)
        {
            using (DocX document = DocX.Create(filename))
            {
                // Crear una tabla con el mismo número de columnas que el DataGridView
                Table table = document.AddTable(Datosdetrabajadores.Rows.Count + 1, Datosdetrabajadores.Columns.Count);

                // Agregar encabezados de columnas a la tabla
                for (int i = 0; i < Datosdetrabajadores.Columns.Count; i++)
                {
                    table.Rows[0].Cells[i].Paragraphs.First().Append(Datosdetrabajadores.Columns[i].HeaderText);
                }

                // Agregar datos de celdas a la tabla
                for (int i = 0; i < Datosdetrabajadores.Rows.Count; i++)
                {
                    for (int j = 0; j < Datosdetrabajadores.Columns.Count; j++)
                    {
                        string valueString = Datosdetrabajadores.Rows[i].Cells[j].Value?.ToString() ?? "";
                        table.Rows[i + 1].Cells[j].Paragraphs.First().Append(valueString);
                    }
                }

                // Insertar la tabla en el documento
                document.InsertTable(table);

                // Guardar el documento
                document.Save();
                Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
            }
        }

        private void ExportarAJSON(string filename)
        {
            List<Dictionary<string, object>> datos = new List<Dictionary<string, object>>();

            // Recorrer las filas y columnas del DataGridView y agregar los datos a la lista
            foreach (DataGridViewRow fila in Datosdetrabajadores.Rows)
            {
                Dictionary<string, object> filaDict = new Dictionary<string, object>();
                foreach (DataGridViewColumn columna in Datosdetrabajadores.Columns)
                {
                    filaDict[columna.Name] = fila.Cells[columna.Index].Value;
                }
                datos.Add(filaDict);
            }

            // Convertir la lista de datos a formato JSON
            string json = JsonConvert.SerializeObject(datos, Formatting.Indented);

            // Guardar el JSON en un archivo
            File.WriteAllText(filename, json);

            Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
            
        }


    }

}
