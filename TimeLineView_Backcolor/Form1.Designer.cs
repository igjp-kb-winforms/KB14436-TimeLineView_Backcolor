
namespace TimeLineView_Backcolor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ultraTimelineView1 = new Infragistics.Win.UltraWinSchedule.UltraTimelineView();
            this.ultraCalendarInfo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(this.components);
            this.ultraCalendarLook1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarLook(this.components);
            this.ultraTimelineView2 = new Infragistics.Win.UltraWinSchedule.UltraTimelineView();
            this.ultraCalendarInfo2 = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(this.components);
            this.ultraCalendarLook2 = new Infragistics.Win.UltraWinSchedule.UltraCalendarLook(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTimelineView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTimelineView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraTimelineView1
            // 
            this.ultraTimelineView1.Location = new System.Drawing.Point(13, 13);
            this.ultraTimelineView1.Name = "ultraTimelineView1";
            this.ultraTimelineView1.Size = new System.Drawing.Size(1022, 298);
            this.ultraTimelineView1.TabIndex = 0;
            // 
            // ultraCalendarInfo1
            // 
            this.ultraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = this;
            this.ultraCalendarInfo1.DataBindingsForOwners.BindingContextControl = this;
            // 
            // ultraTimelineView2
            // 
            this.ultraTimelineView2.Location = new System.Drawing.Point(13, 336);
            this.ultraTimelineView2.Name = "ultraTimelineView2";
            this.ultraTimelineView2.Size = new System.Drawing.Size(1022, 308);
            this.ultraTimelineView2.TabIndex = 1;
            // 
            // ultraCalendarInfo2
            // 
            this.ultraCalendarInfo2.DataBindingsForAppointments.BindingContextControl = this;
            this.ultraCalendarInfo2.DataBindingsForOwners.BindingContextControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 654);
            this.Controls.Add(this.ultraTimelineView2);
            this.Controls.Add(this.ultraTimelineView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTimelineView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTimelineView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinSchedule.UltraTimelineView ultraTimelineView1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo ultraCalendarInfo1;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarLook ultraCalendarLook1;
        private Infragistics.Win.UltraWinSchedule.UltraTimelineView ultraTimelineView2;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo ultraCalendarInfo2;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarLook ultraCalendarLook2;
    }
}

