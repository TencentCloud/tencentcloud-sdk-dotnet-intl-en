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

    public class UnBindingPolicyObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// The value is fixed to monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Policy group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// List of unique IDs of object instances to be deleted.
        /// </summary>
        [JsonProperty("UniqueId")]
        public string[] UniqueId{ get; set; }

        /// <summary>
        /// Instance group ID. The UniqueId parameter is invalid if object instances are deleted by instance group.
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "UniqueId.", this.UniqueId);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
        }
    }
}

