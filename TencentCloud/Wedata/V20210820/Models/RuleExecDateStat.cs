/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleExecDateStat : AbstractModel
    {
        
        /// <summary>
        /// Statistics Date
        /// </summary>
        [JsonProperty("StatDate")]
        public string StatDate{ get; set; }

        /// <summary>
        /// Number of Alerts
        /// </summary>
        [JsonProperty("AlarmCnt")]
        public ulong? AlarmCnt{ get; set; }

        /// <summary>
        /// Number of blocked processes
        /// </summary>
        [JsonProperty("PipelineCnt")]
        public ulong? PipelineCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatDate", this.StatDate);
            this.SetParamSimple(map, prefix + "AlarmCnt", this.AlarmCnt);
            this.SetParamSimple(map, prefix + "PipelineCnt", this.PipelineCnt);
        }
    }
}

