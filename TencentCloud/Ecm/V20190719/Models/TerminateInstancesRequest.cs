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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TerminateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of IDs of the instances to be terminated.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// Whether to enable scheduled termination. Default value: no.
        /// </summary>
        [JsonProperty("TerminateDelay")]
        public bool? TerminateDelay{ get; set; }

        /// <summary>
        /// Scheduled termination time, such as `2019-08-05 12:01:30`. If you don't enable scheduled termination, you can ignore this parameter.
        /// </summary>
        [JsonProperty("TerminateTime")]
        public string TerminateTime{ get; set; }

        /// <summary>
        /// Whether to delete the bound ENI and EIP. Default value: true.
        /// true: the ENI and EIP will also be deleted;
        /// false: only the server will be terminated, while the ENI and EIP will be retained.
        /// </summary>
        [JsonProperty("AssociatedResourceDestroy")]
        public bool? AssociatedResourceDestroy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "TerminateDelay", this.TerminateDelay);
            this.SetParamSimple(map, prefix + "TerminateTime", this.TerminateTime);
            this.SetParamSimple(map, prefix + "AssociatedResourceDestroy", this.AssociatedResourceDestroy);
        }
    }
}

