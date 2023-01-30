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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulTopRankingInfo : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Severity. Valid values: `CRITICAL` (critical); `HIGH` (high);`MIDDLE` (medium);`LOW` (low).
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Number of affected images
        /// </summary>
        [JsonProperty("AffectedImageCount")]
        public long? AffectedImageCount{ get; set; }

        /// <summary>
        /// Number of affected containers
        /// </summary>
        [JsonProperty("AffectedContainerCount")]
        public long? AffectedContainerCount{ get; set; }

        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// POC ID
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "AffectedImageCount", this.AffectedImageCount);
            this.SetParamSimple(map, prefix + "AffectedContainerCount", this.AffectedContainerCount);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
        }
    }
}

