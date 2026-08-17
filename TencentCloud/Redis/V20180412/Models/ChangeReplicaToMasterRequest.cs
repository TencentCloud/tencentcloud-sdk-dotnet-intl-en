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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChangeReplicaToMasterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Specifies the instance ID. Example: crs-xjhsdj****. Log in to the <a href="https://console.cloud.tencent.com/redis">Redis console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Replica node group ID. Use the interface <a href="https://www.tencentcloud.com/document/product/239/50312?from_cn_redirect=1">DescribeInstanceZoneInfo</a> to obtain the id information of the multi-AZ replica node group. For a single AZ, no need to configure this parameter.</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>Emergency mode.</p><p>Enumeration values:</p><ul><li>false: Standard mode (Recommended for security)</li><li>true: Speed mode: (High-risk acceleration) Skip verification, speed up primary node promotion. High-level operation, highly likely to cause a single primary node in abnormal situations.</li></ul><p>Default value: false</p>
        /// </summary>
        [JsonProperty("Emergency")]
        public bool? Emergency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Emergency", this.Emergency);
        }
    }
}

