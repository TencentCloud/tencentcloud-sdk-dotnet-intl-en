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

    public class UpgradeVersionToMultiAvailabilityZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID. Log in to the <a href="https://console.cloud.tencent.com/redis/instance/list">Redis console</a> and copy it from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Whether nearest access is supported after upgrading to multiple availability zones. - true: Supports nearest access. The upgrade process involves upgrading the Proxy version and Redis kernel minor version simultaneously, which may require data migration and take up to several hours. - false: No need to support nearest access. Upgrading to multiple availability zones only involves metadata management migration, with no impact on the service. The upgrade process is usually completed within 3 minutes. Defaults to false.</p>
        /// </summary>
        [JsonProperty("UpgradeProxyAndRedisServer")]
        public bool? UpgradeProxyAndRedisServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpgradeProxyAndRedisServer", this.UpgradeProxyAndRedisServer);
        }
    }
}

