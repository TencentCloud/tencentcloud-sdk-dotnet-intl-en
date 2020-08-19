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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyGroupListRequest : AbstractModel
    {
        
        /// <summary>
        /// The value is fixed to monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Number of parameters that can be returned on each page. Value range: 1 - 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Parameter offset on each page. The value starts from 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Search by policy name.
        /// </summary>
        [JsonProperty("Like")]
        public string Like{ get; set; }

        /// <summary>
        /// Instance group ID.
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// Sort by update time. Valid values: asc and desc.
        /// </summary>
        [JsonProperty("UpdateTimeOrder")]
        public string UpdateTimeOrder{ get; set; }

        /// <summary>
        /// Project ID list.
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// List of alarm policy types.
        /// </summary>
        [JsonProperty("ViewNames")]
        public string[] ViewNames{ get; set; }

        /// <summary>
        /// Whether to filter policy groups without recipients. The value 1 indicates that policy groups without recipients will be filtered. The value 0 indicates that policy groups without recipients will not be filtered.
        /// </summary>
        [JsonProperty("FilterUnuseReceiver")]
        public long? FilterUnuseReceiver{ get; set; }

        /// <summary>
        /// Filter by recipient group.
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// Filter by recipient.
        /// </summary>
        [JsonProperty("ReceiverUserList")]
        public string[] ReceiverUserList{ get; set; }

        /// <summary>
        /// Dimension set field (json string), for example, [[{"name":"unInstanceId","value":"ins-6e4b2aaa"}]].
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// Template-based policy group IDs, which are separated by commas.
        /// </summary>
        [JsonProperty("ConditionTempGroupId")]
        public string ConditionTempGroupId{ get; set; }

        /// <summary>
        /// Filter by recipient or recipient group. The value 'user' indicates by recipient. The value 'group' indicates by recipient group.
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// Filter conditions. Whether the alarm policy has been enabled or disabled
        /// </summary>
        [JsonProperty("IsOpen")]
        public bool? IsOpen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Like", this.Like);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "UpdateTimeOrder", this.UpdateTimeOrder);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ViewNames.", this.ViewNames);
            this.SetParamSimple(map, prefix + "FilterUnuseReceiver", this.FilterUnuseReceiver);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamArraySimple(map, prefix + "ReceiverUserList.", this.ReceiverUserList);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamSimple(map, prefix + "ConditionTempGroupId", this.ConditionTempGroupId);
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
        }
    }
}

