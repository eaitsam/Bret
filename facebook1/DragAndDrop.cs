using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System;

namespace facebook1
{
    class DragAndDrop
    {// Initiate the drag
        private void label1_MouseDown(object sender, MouseEventArgs e) =>
            DoDragDrop(((Label)sender).Text, DragDropEffects.All);

        // Set the effect filter and allow the drop on this control
        private void textBox1_DragOver(object sender, DragEventArgs e) =>
            e.Effect = DragDropEffects.All;

        // React to the drop on this control
        private void textBox1_DragDrop(object sender, DragEventArgs e) =>
            textBox1.Text = (string)e.Data.GetData(typeof(string));
    }
}
