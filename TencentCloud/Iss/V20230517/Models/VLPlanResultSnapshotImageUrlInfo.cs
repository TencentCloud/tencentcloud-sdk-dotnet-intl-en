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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VLPlanResultSnapshotImageUrlInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Analysis result ID</p>
        /// </summary>
        [JsonProperty("VLPlanResultId")]
        public string VLPlanResultId{ get; set; }

        /// <summary>
        /// <p>Source material download URL (empty if unsuccessful)</p>
        /// </summary>
        [JsonProperty("SourceFileURL")]
        public string SourceFileURL{ get; set; }

        /// <summary>
        /// <p>URL validity period (seconds; 0 on failure)</p>
        /// </summary>
        [JsonProperty("Expire")]
        public long? Expire{ get; set; }

        /// <summary>
        /// <p>Error information (has a value on failure)</p>
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VLPlanResultId", this.VLPlanResultId);
            this.SetParamSimple(map, prefix + "SourceFileURL", this.SourceFileURL);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
        }
    }
}

