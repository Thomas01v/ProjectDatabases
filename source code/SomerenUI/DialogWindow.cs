using SomerenModel;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SomerenUI {
    public class DialogWindow : Form {

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButon;
        private Action onConfirmAction;
        
        public DialogWindow(string message, Action onConfirmAction) {
            InitializeComponents(message);
            this.onConfirmAction = onConfirmAction;
        }

        private void InitializeComponents(string message) {

            textLabel = new System.Windows.Forms.Label();
            yesButton = new System.Windows.Forms.Button();
            noButon = new System.Windows.Forms.Button();

            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(18, 18);
            textLabel.Name = "textLabel";
            textLabel.MaximumSize = new System.Drawing.Size(348, 128);
            textLabel.AutoSize = true;
            textLabel.Text = message;
            // 
            // yesButton
            // 
            yesButton.Location = new System.Drawing.Point(18, 146);
            yesButton.Name = "yesButton";
            yesButton.Size = new System.Drawing.Size(94, 29);
            yesButton.TabIndex = 1;
            yesButton.Text = "yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            //
            // noButon
            // 
            noButon.Location = new System.Drawing.Point(256, 146);
            noButon.Name = "noButon";
            noButon.Size = new System.Drawing.Size(94, 29);
            noButon.TabIndex = 2;
            noButon.Text = "no";
            noButon.UseVisualStyleBackColor = true;
            noButon.Click += noButton_Click;

            //
            // DialogWindow
            //
            Controls.Add(textLabel);
            Controls.Add(yesButton);
            Controls.Add(noButon);
            ClientSize = new System.Drawing.Size(384, 192);
            Name = "DialogWindow";
            Text = message;
            ResumeLayout(false);
            PerformLayout();
            Show();
        }

        private void yesButton_Click(object o,  EventArgs e) {
            onConfirmAction();
            this.Close();
        }

        private void noButton_Click(object o, EventArgs e) {
            this.Close();
        }
    }
}
