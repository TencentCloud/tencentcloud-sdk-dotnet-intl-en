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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindAutoSnapshotPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of scheduled snapshot policy to be bound.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// List of cloud disk IDs to be bound. Maximum of 80 cloud disks can be bound per request.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
        }
    }
}

