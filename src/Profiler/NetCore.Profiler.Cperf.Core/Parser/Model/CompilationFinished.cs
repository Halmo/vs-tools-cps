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

using System.Collections.Generic;

namespace NetCore.Profiler.Cperf.Core.Parser.Model
{
    public class CompilationFinished
    {

        public ulong Id { get; }

        public ulong InternalId { get; }

        public ulong ClassId { get; }

        public ulong ModuleId { get; }

        public int FuncToken { get; }

        public ulong Status { get; }

        public List<CodeInfo> CodeInfos { get; } = new List<CodeInfo>();

        public List<CodeMapping> CodeMappings { get; } = new List<CodeMapping>();

        public CompilationFinished(ulong id, ulong internalId, ulong classId, ulong moduleId, int funcToken, ulong status)
        {
            Id = id;
            InternalId = internalId;
            ClassId = classId;
            ModuleId = moduleId;
            FuncToken = funcToken;
            Status = status;
        }

    }
}
