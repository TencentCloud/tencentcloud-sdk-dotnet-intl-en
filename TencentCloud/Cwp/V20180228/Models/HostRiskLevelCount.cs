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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostRiskLevelCount : AbstractModel
    {
        
        /// <summary>
        /// Host ID
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Critical count
        /// </summary>
        [JsonProperty("SeriousCount")]
        public long? SeriousCount{ get; set; }

        /// <summary>
        /// High-risk count
        /// </summary>
        [JsonProperty("HighCount")]
        public long? HighCount{ get; set; }

        /// <summary>
        /// Number of medium-risk vulnerabilities
        /// </summary>
        [JsonProperty("MediumCount")]
        public long? MediumCount{ get; set; }

        /// <summary>
        /// Number of low-risk vulnerabilities
        /// </summary>
        [JsonProperty("LowCount")]
        public long? LowCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "SeriousCount", this.SeriousCount);
            this.SetParamSimple(map, prefix + "HighCount", this.HighCount);
            this.SetParamSimple(map, prefix + "MediumCount", this.MediumCount);
            this.SetParamSimple(map, prefix + "LowCount", this.LowCount);
        }
    }
}

