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

using NetCore.Profiler.Analytics.Model;

namespace NetCore.Profiler.Analytics.DataProvider
{
    public class SourceLineStatistics : ISourceLineStatistics
    {
        public ulong SamplesExclusive { get; set; }
        public ulong SamplesInclusive { get; set; }
        public ulong TimeExclusive { get; set; }
        public ulong TimeInclusive { get; set; }
        public ulong AllocatedMemoryExclusive { get; set; }
        public ulong AllocatedMemoryInclusive { get; set; }
        public ulong StartLine { get; set; }
        public ulong EndLine { get; set; }
        public ulong StartColumn { get; set; }
        public ulong EndColumn { get; set; }
        public string FunctionName { get; set; }
        public ulong SourceFileId { get; set; }
    }
}
