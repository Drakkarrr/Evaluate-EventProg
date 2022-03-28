using System.IO;

namespace Evaluate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            var path = userInput;
            FileInfo fileInfo = new FileInfo(path);

            String[] dirs = System.IO.Directory.GetDirectories(userInput);
            int i;
            for (i = 0; i < dirs.Length; i++)
            {
                listBox1.Items.Add(dirs[i]);
            }

            String[] files = System.IO.Directory.GetFiles(userInput);
            for (i = 0; i < files.Length; i++)
            {
                listBox1.Items.Add(files[i]);

                Console.WriteLine("Filename: " + fileInfo.Name);
                Console.WriteLine("Creation Time: " + fileInfo.CreationTime);
                Console.WriteLine("Modification Time: " + fileInfo.LastWriteTime);

                Console.Read();
            }
               
        }
    }
}