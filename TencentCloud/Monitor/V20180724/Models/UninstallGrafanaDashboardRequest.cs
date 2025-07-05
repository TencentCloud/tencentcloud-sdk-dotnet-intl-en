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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UninstallGrafanaDashboardRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Prometheus integration code, indicating to delete the corresponding dashboard. Valid values:
        /// <li>spring_mvc</li>
        /// <li>mysql</li>
        /// <li>go</li>
        /// <li>redis</li>
        /// <li>jvm</li>
        /// <li>pgsql</li>
        /// <li>mongo</li>
        /// <li>kafka</li>
        /// <li>es</li>
        /// <li>flink</li>
        /// <li>blackbox</li>
        /// <li>consule</li>
        /// <li>memcached</li>
        /// <li>zk</li>
        /// <li>tps</li>
        /// <li>istio</li>
        /// <li>etcd</li>
        /// </summary>
        [JsonProperty("IntegrationCodes")]
        public string[] IntegrationCodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "IntegrationCodes.", this.IntegrationCodes);
        }
    }
}

