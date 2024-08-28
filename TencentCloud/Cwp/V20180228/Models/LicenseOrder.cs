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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseOrder : AbstractModel
    {
        
        /// <summary>
        /// Authorization ID
        /// </summary>
        [JsonProperty("LicenseId")]
        public ulong? LicenseId{ get; set; }

        /// <summary>
        /// Authorization type
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// Authorization Order Resource Status
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Order type
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseId", this.LicenseId);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

