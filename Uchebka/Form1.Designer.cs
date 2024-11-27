namespace Uchebka;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        EnterButton = new Button();
        Email = new TextBox();
        Password = new TextBox();
        ToRegisterButton = new Button();
        label1 = new Label();
        label2 = new Label();
        SuspendLayout();
        // 
        // EnterButton
        // 
        EnterButton.Location = new Point(12, 119);
        EnterButton.Name = "EnterButton";
        EnterButton.Size = new Size(355, 29);
        EnterButton.TabIndex = 0;
        EnterButton.Text = "Войти";
        EnterButton.UseVisualStyleBackColor = true;
        EnterButton.Click += EnterButton_Click;
        // 
        // Email
        // 
        Email.Location = new Point(12, 36);
        Email.Name = "Email";
        Email.Size = new Size(355, 27);
        Email.TabIndex = 1;
        // 
        // Password
        // 
        Password.Location = new Point(12, 86);
        Password.Name = "Password";
        Password.Size = new Size(355, 27);
        Password.TabIndex = 2;
        // 
        // ToRegisterButton
        // 
        ToRegisterButton.Location = new Point(12, 154);
        ToRegisterButton.Name = "ToRegisterButton";
        ToRegisterButton.Size = new Size(355, 29);
        ToRegisterButton.TabIndex = 3;
        ToRegisterButton.Text = "Регистрация";
        ToRegisterButton.UseVisualStyleBackColor = true;
        ToRegisterButton.Click += ToRegisterButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 13);
        label1.Name = "label1";
        label1.Size = new Size(51, 20);
        label1.TabIndex = 4;
        label1.Text = "Почта";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 66);
        label2.Name = "label2";
        label2.Size = new Size(62, 20);
        label2.TabIndex = 5;
        label2.Text = "Пароль";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(379, 196);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(ToRegisterButton);
        Controls.Add(Password);
        Controls.Add(Email);
        Controls.Add(EnterButton);
        Name = "Form1";
        Text = "Вход";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button EnterButton;
    private TextBox Email;
    private TextBox Password;
    private Button ToRegisterButton;
    private Label label1;
    private Label label2;
}