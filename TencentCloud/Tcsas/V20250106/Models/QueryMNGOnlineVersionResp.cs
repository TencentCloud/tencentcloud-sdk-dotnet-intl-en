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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryMNGOnlineVersionResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Mini game appid</p>
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// <p>Version number</p>
        /// </summary>
        [JsonProperty("MNPVersion")]
        public string MNPVersion{ get; set; }

        /// <summary>
        /// <p>Version ID</p>
        /// </summary>
        [JsonProperty("MNPVersionId")]
        public long? MNPVersionId{ get; set; }

        /// <summary>
        /// <p>Version remarks</p>
        /// </summary>
        [JsonProperty("MNPVersionNote")]
        public string MNPVersionNote{ get; set; }

        /// <summary>
        /// <p>Update time</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPVersion", this.MNPVersion);
            this.SetParamSimple(map, prefix + "MNPVersionId", this.MNPVersionId);
            this.SetParamSimple(map, prefix + "MNPVersionNote", this.MNPVersionNote);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

