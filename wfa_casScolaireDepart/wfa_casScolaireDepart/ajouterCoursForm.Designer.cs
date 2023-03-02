namespace wfa_casScolaireDepart
{
    partial class ajouterCoursForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ponderationTextBox = new System.Windows.Forms.TextBox();
            this.nomCoursLlabel = new System.Windows.Forms.Label();
            this.nomCoursTextBox = new System.Windows.Forms.TextBox();
            this.noCoursLabel = new System.Windows.Forms.Label();
            this.noCoursTextBox = new System.Windows.Forms.TextBox();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pondération";
            // 
            // ponderationTextBox
            // 
            this.ponderationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ponderationTextBox.Location = new System.Drawing.Point(226, 136);
            this.ponderationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ponderationTextBox.Name = "ponderationTextBox";
            this.ponderationTextBox.Size = new System.Drawing.Size(247, 34);
            this.ponderationTextBox.TabIndex = 19;
            // 
            // nomCoursLlabel
            // 
            this.nomCoursLlabel.AutoSize = true;
            this.nomCoursLlabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomCoursLlabel.Location = new System.Drawing.Point(36, 85);
            this.nomCoursLlabel.Name = "nomCoursLlabel";
            this.nomCoursLlabel.Size = new System.Drawing.Size(136, 28);
            this.nomCoursLlabel.TabIndex = 18;
            this.nomCoursLlabel.Text = "Nom du cours";
            // 
            // nomCoursTextBox
            // 
            this.nomCoursTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomCoursTextBox.Location = new System.Drawing.Point(226, 85);
            this.nomCoursTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomCoursTextBox.Name = "nomCoursTextBox";
            this.nomCoursTextBox.Size = new System.Drawing.Size(247, 34);
            this.nomCoursTextBox.TabIndex = 17;
            // 
            // noCoursLabel
            // 
            this.noCoursLabel.AutoSize = true;
            this.noCoursLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.noCoursLabel.Location = new System.Drawing.Point(36, 36);
            this.noCoursLabel.Name = "noCoursLabel";
            this.noCoursLabel.Size = new System.Drawing.Size(163, 28);
            this.noCoursLabel.TabIndex = 16;
            this.noCoursLabel.Text = "Numéro de cours";
            // 
            // noCoursTextBox
            // 
            this.noCoursTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.noCoursTextBox.Location = new System.Drawing.Point(226, 36);
            this.noCoursTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noCoursTextBox.Name = "noCoursTextBox";
            this.noCoursTextBox.Size = new System.Drawing.Size(247, 34);
            this.noCoursTextBox.TabIndex = 15;
            // 
            // ajouterButton
            // 
            this.ajouterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ajouterButton.Location = new System.Drawing.Point(322, 194);
            this.ajouterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(151, 44);
            this.ajouterButton.TabIndex = 14;
            this.ajouterButton.Text = "Ajouter";
            this.ajouterButton.UseVisualStyleBackColor = true;
            // 
            // ajouterCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ponderationTextBox);
            this.Controls.Add(this.nomCoursLlabel);
            this.Controls.Add(this.nomCoursTextBox);
            this.Controls.Add(this.noCoursLabel);
            this.Controls.Add(this.noCoursTextBox);
            this.Controls.Add(this.ajouterButton);
            this.Name = "ajouterCoursForm";
            this.Text = "Ajouter un cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ponderationTextBox;
        private System.Windows.Forms.Label nomCoursLlabel;
        private System.Windows.Forms.TextBox nomCoursTextBox;
        private System.Windows.Forms.Label noCoursLabel;
        private System.Windows.Forms.TextBox noCoursTextBox;
        private System.Windows.Forms.Button ajouterButton;
    }
}

