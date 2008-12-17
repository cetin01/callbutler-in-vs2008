///////////////////////////////////////////////////////////////////////////////////////////////
//
//    This File is Part of the CallButler Open Source PBX (http://www.codeplex.com/callbutler
//
//    Copyright (c) 2005-2008, Jim Heising
//    All rights reserved.
//
//    Redistribution and use in source and binary forms, with or without modification,
//    are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice,
//      this list of conditions and the following disclaimer.
//
//    * Redistributions in binary form must reproduce the above copyright notice,
//      this list of conditions and the following disclaimer in the documentation and/or
//      other materials provided with the distribution.
//
//    * Neither the name of Jim Heising nor the names of its contributors may be
//      used to endorse or promote products derived from this software without specific prior
//      written permission.
//
//    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//    ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//    WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
//    IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
//    INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
//    NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//    PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
//    WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
//    ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
//    POSSIBILITY OF SUCH DAMAGE.
//
///////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CallButler.Manager.Plugin;

namespace T2.CallButler.Manager.Plugin.ConferenceBridge
{
    public partial class SettingsForm : Form
    {
        private const string productID = "CB-M-CONF-1";

        CallButlerManagementAddonModulePlugin plugin;

        public SettingsForm(CallButlerManagementAddonModulePlugin plugin)
        {
            InitializeComponent();

            this.plugin = plugin;

            lblLicenseInfo.Text = (string)plugin.ExchangeServicePluginData("GetLicenseInfo", null);
        }

        private void btnLicenseKey_Click(object sender, EventArgs e)
        {
            /*Licensing.Management.LicenseKeyEntryForm entryForm = new Licensing.Management.LicenseKeyEntryForm();

            entryForm.ProductID = productID;

            if (entryForm.ShowDialog(this) == DialogResult.OK)
            {
                plugin.ExchangeServicePluginData("SetLicenseName", entryForm.LicenseToName);
                plugin.ExchangeServicePluginData("SetLicenseKey", entryForm.LicenseKey);

                lblLicenseInfo.Text = (string)plugin.ExchangeServicePluginData("GetLicenseInfo", null);
            }*/
        }
    }
}