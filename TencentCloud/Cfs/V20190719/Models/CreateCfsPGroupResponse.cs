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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCfsPGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// Permission group ID
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// Permission group name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Permission group description
        /// </summary>
        [JsonProperty("DescInfo")]
        public string DescInfo{ get; set; }

        /// <summary>
        /// The number of file systems bound to this permission group
        /// </summary>
        [JsonProperty("BindCfsNum")]
        public long? BindCfsNum{ get; set; }

        /// <summary>
        /// Permission group creation time
        /// </summary>
        [JsonProperty("CDate")]
        public string CDate{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DescInfo", this.DescInfo);
            this.SetParamSimple(map, prefix + "BindCfsNum", this.BindCfsNum);
            this.SetParamSimple(map, prefix + "CDate", this.CDate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

