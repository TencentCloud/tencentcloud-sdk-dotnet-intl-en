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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Target instance type after the change, which is the same as the `TypeId` of the [CreateInstances](https://intl.cloud.tencent.com/document/api/239/20026?from_cn_redirect=1) API.
        /// - For Redis 4.0 or later, a standard architecture instance can be upgraded to a cluster architecture instance on the same version; for example, you can upgrade from Redis 4.0 Standard Architecture to Redis 4.0 Cluster Architecture.
        /// - Cross-version architecture upgrade is not supported; for example, you cannot upgrade from Redis 4.0 Standard Architecture to Redis 5.0 Cluster Architecture.
        /// - The architecture of Redis 2.8 cannot be upgraded.
        /// - Cluster architecture cannot be downgraded to standard architecture.
        /// </summary>
        [JsonProperty("TargetInstanceType")]
        public string TargetInstanceType{ get; set; }

        /// <summary>
        /// Switch time. Valid values:
        /// - `1`: Switch in the maintenance time.
        /// - `2` (default value): Switch now.
        /// </summary>
        [JsonProperty("SwitchOption")]
        public long? SwitchOption{ get; set; }

        /// <summary>
        /// ID of the specified instance, such as `crs-xjhsdj****`. Log in to the [Redis console](https://console.cloud.tencent.com/redis#/), and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetInstanceType", this.TargetInstanceType);
            this.SetParamSimple(map, prefix + "SwitchOption", this.SwitchOption);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

