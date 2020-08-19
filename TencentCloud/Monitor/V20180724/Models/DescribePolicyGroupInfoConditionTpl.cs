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

    public class DescribePolicyGroupInfoConditionTpl : AbstractModel
    {
        
        /// <summary>
        /// Policy group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Policy group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Policy type.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// Policy group remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Uin that was last edited.
        /// </summary>
        [JsonProperty("LastEditUin")]
        public string LastEditUin{ get; set; }

        /// <summary>
        /// Update time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InsertTime")]
        public long? InsertTime{ get; set; }

        /// <summary>
        /// Whether the 'AND' rule is used.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "LastEditUin", this.LastEditUin);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
        }
    }
}

