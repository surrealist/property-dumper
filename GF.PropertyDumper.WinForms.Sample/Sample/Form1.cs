using GF.PropertyDumper;
using System;
using System.Windows.Forms;

namespace Sample {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      PropertyDumper.Dump(sender, s => listBox1.Items.Add(s));
    }
  }
}
