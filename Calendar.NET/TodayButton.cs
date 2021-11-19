namespace Calendar.NET
{
    internal class TodayButton : CoolButton
    {
        public TodayButton()
        {
            Size = new System.Drawing.Size(72, 29);
            ButtonText = "Hoy";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TodayButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "TodayButton";
            this.Load += new System.EventHandler(this.TodayButton_Load);
            this.ResumeLayout(false);

        }

        private void TodayButton_Load(object sender, System.EventArgs e)
        {

        }
    }
}
