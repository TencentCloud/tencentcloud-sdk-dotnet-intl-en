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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// ID of a placement group.
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// Name of a placement group.
        /// </summary>
        [JsonProperty("DeployGroupName")]
        public string DeployGroupName{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Instance quota of placement group, indicating the maximum number of instances that can be placed in one placement group.
        /// </summary>
        [JsonProperty("Quota")]
        public long? Quota{ get; set; }

        /// <summary>
        /// Affinity policy of placement group. Currently, only policy 1 is supported, indicating to distribute instances across physical machines.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Affinity")]
        public string Affinity{ get; set; }

        /// <summary>
        /// Upper limit of instances in one placement group on one physical machine as defined in affinity policy 1 of placement group.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LimitNum")]
        public long? LimitNum{ get; set; }

        /// <summary>
        /// Placement group details.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Physical model attribute of placement group.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DevClass")]
        public string DevClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployGroupId", this.DeployGroupId);
            this.SetParamSimple(map, prefix + "DeployGroupName", this.DeployGroupName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Quota", this.Quota);
            this.SetParamSimple(map, prefix + "Affinity", this.Affinity);
            this.SetParamSimple(map, prefix + "LimitNum", this.LimitNum);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DevClass", this.DevClass);
        }
    }
}

