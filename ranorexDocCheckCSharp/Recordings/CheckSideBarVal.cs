﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ranorexDocCheckCSharp.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckSideBarVal recording.
    /// </summary>
    [TestModule("9692a7c0-dfe1-4a7a-a145-68cb8edce5fb", ModuleType.Recording, 1)]
    public partial class CheckSideBarVal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ranorexDocCheckCSharp.ranorexDocCheckCSharpRepository repository.
        /// </summary>
        public static global::ranorexDocCheckCSharp.ranorexDocCheckCSharpRepository repo = global::ranorexDocCheckCSharp.ranorexDocCheckCSharpRepository.Instance;

        static CheckSideBarVal instance = new CheckSideBarVal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckSideBarVal()
        {
            menu1 = "";
            menu2 = "";
            menu3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckSideBarVal Instance
        {
            get { return instance; }
        }

#region Variables

        string _menu1;

        /// <summary>
        /// Gets or sets the value of variable menu1.
        /// </summary>
        [TestVariable("71ec37e6-52b9-4574-983b-9374a4c3f61d")]
        public string menu1
        {
            get { return _menu1; }
            set { _menu1 = value; }
        }

        string _menu2;

        /// <summary>
        /// Gets or sets the value of variable menu2.
        /// </summary>
        [TestVariable("9d540db9-74d0-45f3-a98f-913e399d9423")]
        public string menu2
        {
            get { return _menu2; }
            set { _menu2 = value; }
        }

        string _menu3;

        /// <summary>
        /// Gets or sets the value of variable menu3.
        /// </summary>
        [TestVariable("84de672a-2777-4f72-88c8-004ac1de3110")]
        public string menu3
        {
            get { return _menu3; }
            set { _menu3 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SquashTFExecutionServer'.", repo.ApplicationUnderTest.SquashTFExecutionServerInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SquashTFExecutionServerInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Squash TF Execution Server') on item 'ApplicationUnderTest.SquashTFExecutionServer'.", repo.ApplicationUnderTest.SquashTFExecutionServerInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SquashTFExecutionServerInfo, "InnerText", "Squash TF Execution Server");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'ApplicationUnderTest.SquashTFExecutionServer'.", repo.ApplicationUnderTest.SquashTFExecutionServerInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SquashTFExecutionServerInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SomeUlTag.Administration'.", repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$menu1) on item 'ApplicationUnderTest.SomeUlTag.Administration'.", repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, "InnerText", menu1);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='a') on item 'ApplicationUnderTest.SomeUlTag.Administration'.", repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, "TagName", "a");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://squash-tf.readthedocs.io/projects/execution-server/en/doc-stable/admin/admin.html') on item 'ApplicationUnderTest.SomeUlTag.Administration'.", repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.AdministrationInfo, "Href", "https://squash-tf.readthedocs.io/projects/execution-server/en/doc-stable/admin/admin.html");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SomeUlTag.Usage'.", repo.ApplicationUnderTest.SomeUlTag.UsageInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.UsageInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$menu2) on item 'ApplicationUnderTest.SomeUlTag.Usage'.", repo.ApplicationUnderTest.SomeUlTag.UsageInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.UsageInfo, "InnerText", menu2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='a') on item 'ApplicationUnderTest.SomeUlTag.Usage'.", repo.ApplicationUnderTest.SomeUlTag.UsageInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.UsageInfo, "TagName", "a");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://squash-tf.readthedocs.io/projects/execution-server/en/doc-stable/usage/usage.html') on item 'ApplicationUnderTest.SomeUlTag.Usage'.", repo.ApplicationUnderTest.SomeUlTag.UsageInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.UsageInfo, "Href", "https://squash-tf.readthedocs.io/projects/execution-server/en/doc-stable/usage/usage.html");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.SomeUlTag.Download'.", repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$menu3) on item 'ApplicationUnderTest.SomeUlTag.Download'.", repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, "InnerText", menu3);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='a') on item 'ApplicationUnderTest.SomeUlTag.Download'.", repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, "TagName", "a");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://squash-tf.readthedocs.io/en/latest/download.html#squash-tf-execution-server') on item 'ApplicationUnderTest.SomeUlTag.Download'.", repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeUlTag.DownloadInfo, "Href", "https://squash-tf.readthedocs.io/en/latest/download.html#squash-tf-execution-server");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
