﻿using System;
using Toolkit.Text;
using System.Drawing;
using Toolkit.EnvironmentX;
using System.Windows.Forms;

// Sonic '06 Toolkit is licensed under the MIT License:
/*
 * MIT License

 * Copyright (c) 2020 Gabriel (HyperPolygon64)

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Toolkit.Logs
{
    public partial class ToolkitSessionLog : Form
    {
        int locationX = 0;
        int locationY = 0;

        public ToolkitSessionLog() {
            InitializeComponent();
            Location = new Point(Properties.Settings.Default.log_X, Properties.Settings.Default.log_Y);
            Properties.Settings.Default.log_Startup = true;
            options_Timestamps.Checked = Properties.Settings.Default.log_timestamps;

            if (Properties.Settings.Default.log_priority == 0) { 
                priority_TopToBottom.Checked = true;
                priority_BottomToTop.Checked = false;
            } else if (Properties.Settings.Default.log_priority == 1) {
                priority_TopToBottom.Checked = false;
                priority_BottomToTop.Checked = true;
            }

            list_Logs.Items.Clear();
            list_Logs.Items.Add($"{SystemMessages.tl_DefaultTitleVersion} - Session ID: {Program.sessionID}");
            list_Logs.Items.Add("");

            if (Properties.Settings.Default.log_priority == 0)
                for (int i = Main.sessionLog.Count - 1; i >= 0; i--) list_Logs.Items.Add(Main.sessionLog[i]);
            else
                foreach (string log in Main.sessionLog) list_Logs.Items.Add(log);

            if (Properties.Settings.Default.log_refreshTimer != 0) {
                nud_RefreshTimer.Value = Convert.ToDecimal(Properties.Settings.Default.log_refreshTimer) / 1000;
                if (nud_RefreshTimer.Value == 1) lbl_RefreshText.Text = "Refresh every:                      second";
                else lbl_RefreshText.Text = "Refresh every:                      seconds";
                tm_RefreshLogs.Interval = Properties.Settings.Default.log_refreshTimer;
                tm_RefreshLogs.Start();
            } else {
                nud_RefreshTimer.Value = 0;
                lbl_RefreshText.Text = "Refresh every:                      seconds";
                btn_TimerEnabled.Text = "Resume";
                tm_RefreshLogs.Stop();
            }
        }

        private void List_Logs_SelectedIndexChanged(object sender, EventArgs e) { list_Logs.ClearSelected(); }

        private void Btn_Clear_Click(object sender, EventArgs e) { Main.sessionLog.Clear(); }

        private void Tm_RefreshLogs_Tick(object sender, EventArgs e) {
            list_Logs.Items.Clear();
            list_Logs.Items.Add($"{SystemMessages.tl_DefaultTitleVersion} - Session ID: {Program.sessionID}");
            list_Logs.Items.Add("");

            if (Properties.Settings.Default.log_priority == 0)
                for (int i = Main.sessionLog.Count - 1; i >= 0; i--) list_Logs.Items.Add(Main.sessionLog[i]);
            else
                foreach (string log in Main.sessionLog) list_Logs.Items.Add(log);
        }

        private void Nud_RefreshTimer_ValueChanged(object sender, EventArgs e) {
            if (nud_RefreshTimer.Value == 0) {
                lbl_RefreshText.Text = "Refresh every:                      seconds";
                btn_TimerEnabled.Text = "Resume";
                tm_RefreshLogs.Stop();
            } else if (nud_RefreshTimer.Value == 1) {
                lbl_RefreshText.Text = "Refresh every:                      second";
                btn_TimerEnabled.Text = "Pause";
                tm_RefreshLogs.Start();
            } else { 
                lbl_RefreshText.Text = "Refresh every:                      seconds";
                btn_TimerEnabled.Text = "Pause";
                tm_RefreshLogs.Start();
            }
            if (nud_RefreshTimer.Value != 0) Properties.Settings.Default.log_refreshTimer = tm_RefreshLogs.Interval = decimal.ToInt32(nud_RefreshTimer.Value) * 1000;
            else Properties.Settings.Default.log_refreshTimer = 0;
        }

        private void ToolkitSessionLog_FormClosing(object sender, FormClosingEventArgs e) {
            if (WindowState == FormWindowState.Maximized) {
                Properties.Settings.Default.log_X = 25;
                Properties.Settings.Default.log_Y = 25;
            } else {
                Properties.Settings.Default.log_X = Left;
                Properties.Settings.Default.log_Y = Top;
            }
            Properties.Settings.Default.log_timestamps = options_Timestamps.Checked;
            Properties.Settings.Default.log_Startup = false;

            if (priority_TopToBottom.Checked) Properties.Settings.Default.log_priority = 0;
            else if (priority_BottomToTop.Checked) Properties.Settings.Default.log_priority = 1;
        }

        private void Btn_TimerEnabled_Click(object sender, EventArgs e) {
            if (tm_RefreshLogs.Enabled) { btn_TimerEnabled.Text = "Resume"; tm_RefreshLogs.Stop(); }
            else { btn_TimerEnabled.Text = "Pause"; tm_RefreshLogs.Start(); }
        }

        private void ToolkitSessionLog_Move(object sender, EventArgs e) {
            Properties.Settings.Default.log_X = Left;
            Properties.Settings.Default.log_Y = Top;
        }

        private void Options_Timestamps_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.log_timestamps = options_Timestamps.Checked;
        }

        private void Priority_TopToBottom_CheckedChanged(object sender, EventArgs e) {
            if (priority_TopToBottom.Checked) {
                Properties.Settings.Default.log_priority = 0;
                priority_BottomToTop.Checked = false;
            } else {
                Properties.Settings.Default.log_priority = 1;
                priority_BottomToTop.Checked = true;
            }
        }

        private void Priority_BottomToTop_CheckedChanged(object sender, EventArgs e) {
            if (priority_BottomToTop.Checked) {
                Properties.Settings.Default.log_priority = 1;
                priority_TopToBottom.Checked = false;
            } else {
                Properties.Settings.Default.log_priority = 0;
                priority_TopToBottom.Checked = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e) {
            list_Logs.Items.Clear();
            list_Logs.Items.Add($"{SystemMessages.tl_DefaultTitleVersion} - Session ID: {Program.sessionID}");
            list_Logs.Items.Add("");

            if (Properties.Settings.Default.log_priority == 0)
                for (int i = Main.sessionLog.Count - 1; i >= 0; i--) list_Logs.Items.Add(Main.sessionLog[i]);
            else
                foreach (string log in Main.sessionLog) list_Logs.Items.Add(log);
        }

        private void ToolkitSessionLog_Resize(object sender, EventArgs e) {
            locationX = Location.X;
            locationY = Location.Y;
            if (WindowState == FormWindowState.Maximized) {
                Properties.Settings.Default.log_X = 25;
                Properties.Settings.Default.log_Y = 25;
            } else {
                Properties.Settings.Default.log_X = locationX;
                Properties.Settings.Default.log_Y = locationY;
            }
        }
    }
}
