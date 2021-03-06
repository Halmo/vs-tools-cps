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
using System.Linq;

namespace NetCore.Profiler.Analytics.DataProvider
{
    public class FunctionCall
    {

        public ulong SamplesExclusive { get; set; }

        public ulong SamplesInclusive { get; set; }

        public ulong TimeExclusive { get; set; }

        public ulong TimeInclusive { get; set; }

        public ulong AllocatedMemoryExclusive { get; set; }

        public ulong AllocatedMemoryInclusive { get; set; }

        public string Signature { get; set; }

        public string Name { get; set; }

        public ulong FunctionIntId { get; set; }

        public FunctionCall Parent { get; set; }

        public List<FunctionCall> Children { get; set; } = new List<FunctionCall>();

        public ulong? Ip { get; set; }

        public FunctionCall(ulong functionIntId, string name, string signature)
        {
            FunctionIntId = functionIntId;
            Name = name;
            Signature = signature;
        }

        public FunctionCall FindChildById(ulong functionIntId)
        {
            return Children.FirstOrDefault(call => call.FunctionIntId == functionIntId);
        }

    }
}
