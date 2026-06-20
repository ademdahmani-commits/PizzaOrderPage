using System.Runtime.CompilerServices;

namespace PizzaPage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.ThickCrust = new System.Windows.Forms.RadioButton();
            this.thinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhere_To_Eat = new System.Windows.Forms.GroupBox();
            this.TakeOut = new System.Windows.Forms.RadioButton();
            this.EatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.ResetForm = new System.Windows.Forms.Button();
            this.gbToppingsChecks = new System.Windows.Forms.GroupBox();
            this.Green_Peppers = new System.Windows.Forms.CheckBox();
            this.Olives = new System.Windows.Forms.CheckBox();
            this.Onion = new System.Windows.Forms.CheckBox();
            this.Tomatos = new System.Windows.Forms.CheckBox();
            this.Mushrooms = new System.Windows.Forms.CheckBox();
            this.ExtraChesse = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.labelWhereToEatT = new System.Windows.Forms.Label();
            this.labelCrustTypeT = new System.Windows.Forms.Label();
            this.labelToppingsT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhere_To_Eat.SuspendLayout();
            this.gbToppingsChecks.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.radioLarge);
            this.gbSize.Controls.Add(this.radioMedium);
            this.gbSize.Controls.Add(this.radioSmall);
            resources.ApplyResources(this.gbSize, "gbSize");
            this.gbSize.Name = "gbSize";
            this.gbSize.TabStop = false;
            // 
            // radioLarge
            // 
            resources.ApplyResources(this.radioLarge, "radioLarge");
            this.radioLarge.ForeColor = System.Drawing.Color.Black;
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Tag = "15";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.CheckedChanged += new System.EventHandler(this.radioLarge_CheckedChanged);
            // 
            // radioMedium
            // 
            resources.ApplyResources(this.radioMedium, "radioMedium");
            this.radioMedium.ForeColor = System.Drawing.Color.Black;
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Tag = "10";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // radioSmall
            // 
            resources.ApplyResources(this.radioSmall, "radioSmall");
            this.radioSmall.ForeColor = System.Drawing.Color.Black;
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Tag = "5";
            this.radioSmall.UseVisualStyleBackColor = true;
            this.radioSmall.CheckedChanged += new System.EventHandler(this.radioSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.ThickCrust);
            this.gbCrustType.Controls.Add(this.thinCrust);
            resources.ApplyResources(this.gbCrustType, "gbCrustType");
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.TabStop = false;
            // 
            // ThickCrust
            // 
            resources.ApplyResources(this.ThickCrust, "ThickCrust");
            this.ThickCrust.ForeColor = System.Drawing.Color.Black;
            this.ThickCrust.Name = "ThickCrust";
            this.ThickCrust.Tag = "5";
            this.ThickCrust.UseVisualStyleBackColor = true;
            this.ThickCrust.CheckedChanged += new System.EventHandler(this.ThinkCrust_CheckedChanged);
            // 
            // thinCrust
            // 
            resources.ApplyResources(this.thinCrust, "thinCrust");
            this.thinCrust.ForeColor = System.Drawing.Color.Black;
            this.thinCrust.Name = "thinCrust";
            this.thinCrust.Tag = "10";
            this.thinCrust.UseVisualStyleBackColor = true;
            this.thinCrust.CheckedChanged += new System.EventHandler(this.thinCrust_CheckedChanged);
            // 
            // gbWhere_To_Eat
            // 
            this.gbWhere_To_Eat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhere_To_Eat.Controls.Add(this.TakeOut);
            this.gbWhere_To_Eat.Controls.Add(this.EatIn);
            resources.ApplyResources(this.gbWhere_To_Eat, "gbWhere_To_Eat");
            this.gbWhere_To_Eat.Name = "gbWhere_To_Eat";
            this.gbWhere_To_Eat.TabStop = false;
            // 
            // TakeOut
            // 
            resources.ApplyResources(this.TakeOut, "TakeOut");
            this.TakeOut.ForeColor = System.Drawing.Color.Black;
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.CheckedChanged += new System.EventHandler(this.TakeOut_CheckedChanged);
            // 
            // EatIn
            // 
            resources.ApplyResources(this.EatIn, "EatIn");
            this.EatIn.ForeColor = System.Drawing.Color.Black;
            this.EatIn.Name = "EatIn";
            this.EatIn.UseVisualStyleBackColor = true;
            this.EatIn.CheckedChanged += new System.EventHandler(this.EatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btnOrderPizza, "btnOrderPizza");
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.OrderPizza_Click);
            // 
            // ResetForm
            // 
            this.ResetForm.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.ResetForm, "ResetForm");
            this.ResetForm.Name = "ResetForm";
            this.ResetForm.UseVisualStyleBackColor = false;
            this.ResetForm.Click += new System.EventHandler(this.ResetForm_Click);
            // 
            // gbToppingsChecks
            // 
            this.gbToppingsChecks.BackColor = System.Drawing.Color.Transparent;
            this.gbToppingsChecks.Controls.Add(this.Green_Peppers);
            this.gbToppingsChecks.Controls.Add(this.Olives);
            this.gbToppingsChecks.Controls.Add(this.Onion);
            this.gbToppingsChecks.Controls.Add(this.Tomatos);
            this.gbToppingsChecks.Controls.Add(this.Mushrooms);
            this.gbToppingsChecks.Controls.Add(this.ExtraChesse);
            resources.ApplyResources(this.gbToppingsChecks, "gbToppingsChecks");
            this.gbToppingsChecks.Name = "gbToppingsChecks";
            this.gbToppingsChecks.TabStop = false;
            // 
            // Green_Peppers
            // 
            resources.ApplyResources(this.Green_Peppers, "Green_Peppers");
            this.Green_Peppers.ForeColor = System.Drawing.Color.Black;
            this.Green_Peppers.Name = "Green_Peppers";
            this.Green_Peppers.Tag = "3";
            this.Green_Peppers.UseVisualStyleBackColor = true;
            this.Green_Peppers.CheckedChanged += new System.EventHandler(this.Green_Peppers_CheckedChanged);
            // 
            // Olives
            // 
            resources.ApplyResources(this.Olives, "Olives");
            this.Olives.ForeColor = System.Drawing.Color.Black;
            this.Olives.Name = "Olives";
            this.Olives.Tag = "2";
            this.Olives.UseVisualStyleBackColor = true;
            this.Olives.CheckedChanged += new System.EventHandler(this.Olives_CheckedChanged);
            // 
            // Onion
            // 
            resources.ApplyResources(this.Onion, "Onion");
            this.Onion.ForeColor = System.Drawing.Color.Black;
            this.Onion.Name = "Onion";
            this.Onion.Tag = "2";
            this.Onion.UseVisualStyleBackColor = true;
            this.Onion.CheckedChanged += new System.EventHandler(this.Onion_CheckedChanged);
            // 
            // Tomatos
            // 
            resources.ApplyResources(this.Tomatos, "Tomatos");
            this.Tomatos.ForeColor = System.Drawing.Color.Black;
            this.Tomatos.Name = "Tomatos";
            this.Tomatos.Tag = "2";
            this.Tomatos.UseVisualStyleBackColor = true;
            this.Tomatos.CheckedChanged += new System.EventHandler(this.Tomatos_CheckedChanged);
            // 
            // Mushrooms
            // 
            resources.ApplyResources(this.Mushrooms, "Mushrooms");
            this.Mushrooms.ForeColor = System.Drawing.Color.Black;
            this.Mushrooms.Name = "Mushrooms";
            this.Mushrooms.Tag = "5";
            this.Mushrooms.UseVisualStyleBackColor = true;
            this.Mushrooms.CheckedChanged += new System.EventHandler(this.Mushrooms_CheckedChanged);
            // 
            // ExtraChesse
            // 
            resources.ApplyResources(this.ExtraChesse, "ExtraChesse");
            this.ExtraChesse.ForeColor = System.Drawing.Color.Black;
            this.ExtraChesse.Name = "ExtraChesse";
            this.ExtraChesse.Tag = "3";
            this.ExtraChesse.UseVisualStyleBackColor = true;
            this.ExtraChesse.CheckedChanged += new System.EventHandler(this.ExtraChess_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.labelWhereToEat);
            this.groupBox4.Controls.Add(this.labelCrustType);
            this.groupBox4.Controls.Add(this.labelToppings);
            this.groupBox4.Controls.Add(this.LabelSize);
            this.groupBox4.Controls.Add(this.labelWhereToEatT);
            this.groupBox4.Controls.Add(this.labelCrustTypeT);
            this.groupBox4.Controls.Add(this.labelToppingsT);
            this.groupBox4.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // labelWhereToEat
            // 
            resources.ApplyResources(this.labelWhereToEat, "labelWhereToEat");
            this.labelWhereToEat.ForeColor = System.Drawing.Color.Green;
            this.labelWhereToEat.Name = "labelWhereToEat";
            // 
            // labelCrustType
            // 
            resources.ApplyResources(this.labelCrustType, "labelCrustType");
            this.labelCrustType.ForeColor = System.Drawing.Color.Green;
            this.labelCrustType.Name = "labelCrustType";
            // 
            // labelToppings
            // 
            this.labelToppings.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelToppings, "labelToppings");
            this.labelToppings.ForeColor = System.Drawing.Color.Green;
            this.labelToppings.Name = "labelToppings";
            // 
            // LabelSize
            // 
            resources.ApplyResources(this.LabelSize, "LabelSize");
            this.LabelSize.ForeColor = System.Drawing.Color.Green;
            this.LabelSize.Name = "LabelSize";
            // 
            // labelWhereToEatT
            // 
            resources.ApplyResources(this.labelWhereToEatT, "labelWhereToEatT");
            this.labelWhereToEatT.ForeColor = System.Drawing.Color.Black;
            this.labelWhereToEatT.Name = "labelWhereToEatT";
            // 
            // labelCrustTypeT
            // 
            resources.ApplyResources(this.labelCrustTypeT, "labelCrustTypeT");
            this.labelCrustTypeT.ForeColor = System.Drawing.Color.Black;
            this.labelCrustTypeT.Name = "labelCrustTypeT";
            // 
            // labelToppingsT
            // 
            resources.ApplyResources(this.labelToppingsT, "labelToppingsT");
            this.labelToppingsT.ForeColor = System.Drawing.Color.Black;
            this.labelToppingsT.Name = "labelToppingsT";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbToppingsChecks);
            this.Controls.Add(this.ResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhere_To_Eat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhere_To_Eat.ResumeLayout(false);
            this.gbWhere_To_Eat.PerformLayout();
            this.gbToppingsChecks.ResumeLayout(false);
            this.gbToppingsChecks.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton ThickCrust;
        private System.Windows.Forms.RadioButton thinCrust;
        private System.Windows.Forms.GroupBox gbWhere_To_Eat;
        private System.Windows.Forms.RadioButton TakeOut;
        private System.Windows.Forms.RadioButton EatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button ResetForm;
        private System.Windows.Forms.GroupBox gbToppingsChecks;
        private System.Windows.Forms.CheckBox Green_Peppers;
        private System.Windows.Forms.CheckBox Olives;
        private System.Windows.Forms.CheckBox Onion;
        private System.Windows.Forms.CheckBox Tomatos;
        private System.Windows.Forms.CheckBox Mushrooms;
        private System.Windows.Forms.CheckBox ExtraChesse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelToppingsT;
        private System.Windows.Forms.Label labelWhereToEatT;
        private System.Windows.Forms.Label labelCrustTypeT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label LabelSize;
        
    }
}

