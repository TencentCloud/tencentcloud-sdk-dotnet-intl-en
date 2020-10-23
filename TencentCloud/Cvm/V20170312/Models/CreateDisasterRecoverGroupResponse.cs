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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDisasterRecoverGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// List of spread placement group IDs.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupId")]
        public string DisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// Type of the spread placement group. Valid values: <br><li>HOST: physical machine <br><li>SW: switch <br><li>RACK: rack.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Name of the spread placement group. The name must be 1-60 characters long and can contain both Chinese characters and English letters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The maximum number of CVMs in a placement group.
        /// </summary>
        [JsonProperty("CvmQuotaTotal")]
        public long? CvmQuotaTotal{ get; set; }

        /// <summary>
        /// The current number of CVMs in a placement group.
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

        /// <summary>
        /// Creation time of the placement group.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupId", this.DisasterRecoverGroupId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CvmQuotaTotal", this.CvmQuotaTotal);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

