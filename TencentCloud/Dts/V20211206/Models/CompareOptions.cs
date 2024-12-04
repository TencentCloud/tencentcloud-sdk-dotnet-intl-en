/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareOptions : AbstractModel
    {
        
        /// <summary>
        /// Comparative Method: dataCheck (Complete Data Comparison), sampleDataCheck (Sampling Data Comparison), rowsCount (Row Count Comparison)Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Sampling rate. Value range: 0-100%.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// The number of threads, which defaults to 1. Value range: 1-5.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ThreadCount")]
        public long? ThreadCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "ThreadCount", this.ThreadCount);
        }
    }
}

