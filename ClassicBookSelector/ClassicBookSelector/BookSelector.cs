using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicBookSelector
{
    public partial class BookSelector : Form
    {
        public BookSelector()
        {
            InitializeComponent();

            //Prompts and event handler from when the mouse cursor enters the listbox1
            listBox1.MouseEnter += new System.EventHandler(listBox1_MouseEnter);
            listBox1.MouseLeave += new System.EventHandler(listBox1_MouseLeave);

        }

        private void BookSelector_Load(object sender, EventArgs e)
        {

        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                desLabel.Text = "Great Expectations follows the young protagonist Pip, a lower-class orphan who lives with his sister and her husband in Kent. ... " +
                    "            Pip becomes enamored with Estella, Miss Havisham's young ward. Estella is beautiful yet cruel, " +
                    "            and Pip makes it his life's mission to become a wealthy gentleman worthy of being her husband. ";
            }
        }

        private void listBox1_MouseEnter(object sender, System.EventArgs e)
        {

            readingLabel.Visible = true; 
        }

        private void listBox1_MouseLeave(object sender, System.EventArgs e)
        {

            readingLabel.Visible = false;
        }

        private void desLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                desLabel.Text = "Great Expectations follows the young protagonist Pip, a lower-class orphan\n " +
                                "who lives with his sister and her husband in Kent. Pip becomes enamored with \n" +
                                "Estella, Miss Havisham's young ward. Estella is beautiful yet cruel,\n " +
                                "and Pip makes it his life's mission to become a wealthy gentleman worthy \n" +
                                "of being her husband. ";

                this.BackColor = Color.Coral;
            }
            if (listBox1.SelectedIndex == 1)
            {
                desLabel.Text = "1984 is a dystopian novella by George Orwell published in 1949, which follows\n " +
                                "the life of  Winston Smith, a low ranking member of 'the Party', who is frus- \n" +
                                "trated by the omnipresent eyes of the part, and its ominous ruler Big Brother.\n " +
                                "'Big Brother' controls every aspect of people's lives. \n";

                this.BackColor = Color.LightCoral;
            }
            if (listBox1.SelectedIndex == 2)
            {
                desLabel.Text = "To Kill a Mockingbird is the story of a young girl named Scout whose father\n " +
                                "is a lawyer defending a black man accused of raping a white woman. She lives in \n" +
                                "a small Southern town that is shaken by the trial, because the man could not\n " +
                                "have physically commmitted the crime. \n";

                this.BackColor = Color.LightBlue;
            }
            if (listBox1.SelectedIndex == 3)
            {
                desLabel.Text = "The book tells the story of a group of farm animals who rebel against their\n " +
                                "human farmer, hoping to create a society where the animals can be equal, free, \n" +
                                "and happy. Ultimately, however, the rebellion is betrayed and the farm ends up\n " +
                                "in a state as bad as it was before, under the dictatorship of a pig named - \n" +
                                "Napoleon ";

                this.BackColor = Color.LightGreen;
            }
            if (listBox1.SelectedIndex == 4)
            {
                desLabel.Text = "The Great Gatsby, third novel by F. Scott Fitzgerald, published in 1925. Set in\n " +
                                "Jazz Age New York, the novel tells the tragic story of Jay Gatsby, a self-made \n" +
                                "millionaire, and his pursuit of Daisy Buchanan, a wealthy young woman whom he\n " +
                                "love in his youth. \n";

                this.BackColor = Color.LightPink;
            }
        }
    }
}
