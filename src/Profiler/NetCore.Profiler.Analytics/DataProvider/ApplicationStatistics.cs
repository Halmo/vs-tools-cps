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
using NetCore.Profiler.Analytics.Model;

namespace NetCore.Profiler.Analytics.DataProvider
{
    public class ApplicationStatistics : IApplicationStatistics
    {
        public IProfilingStatisticsTotals Totals { get; set; }

        public Dictionary<StatisticsType, List<IMethodStatistics>> Methods { get; set; }

        public Dictionary<StatisticsType, List<ISourceLineStatistics>> Lines { get; set; }
    }
}
