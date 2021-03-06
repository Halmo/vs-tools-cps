﻿/*
 * Copyright 2017 (c) Samsung Electronics Co., Ltd  All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * 	http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using EnvDTE;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.IO;

namespace Tizen.VisualStudio.ProjectWizard
{
    internal class ProjectWizardPortableUI : IWizard
    {
        public static Dictionary<string, string> UIDictionary =
                                    new Dictionary<string, string>();

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            if (replacementsDictionary["$ext_hasSharedLib$"] != "true")
            {
                new DirectoryInfo(replacementsDictionary["$destinationdirectory$"]).Delete();
                throw new WizardCancelledException();
            }
            else
            {
                UIDictionary["$txui_safeprojectname$"] =
                            replacementsDictionary["$safeprojectname$"];
                UIDictionary["$txui_guid1$"] =
                                replacementsDictionary["$guid1$"];
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
