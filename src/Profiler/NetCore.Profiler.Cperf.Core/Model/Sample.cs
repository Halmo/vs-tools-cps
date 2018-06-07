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

namespace NetCore.Profiler.Cperf.Core.Model
{
    public class Sample
    {
        public ulong ThreadIntId { get; set; } = ulong.MaxValue;

        public ulong Timestamp { get; set; }

        public ulong Samples { get; set; }

        public ulong Time { get; set; }

        public ulong AllocatedMemory { get; set; }

        public List<SampleStackItem> StackItems { get; } = new List<SampleStackItem>();

        public List<SampleAllocationItem> AllocationItems { get; } = new List<SampleAllocationItem>();
    }

    public class SampleStackItem
    {
        public ulong FunctionIntId { get; set; }

        public ulong? SourceLineId { get; set; }

    }

    public class SampleAllocationItem
    {
        public ulong AllocationCount { get; set; }

        public ulong MemorySize { get; set; }

        public ulong? SourceLineId { get; set; }

    }

}
