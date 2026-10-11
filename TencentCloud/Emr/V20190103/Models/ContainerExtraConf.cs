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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContainerExtraConf : AbstractModel
    {
        
        /// <summary>
        /// <p>Proxy access type for computing jobs, such as Spark jobs and the RayCluster UI. If not specified, Internal is used by default.</p><p>Enumeration values:</p><ul><li>Internal: access through the private network LB proxy.</li><li>Public: access through the public network LB proxy.</li><li>None: No LB proxy access is created.</li></ul>
        /// </summary>
        [JsonProperty("JobAccessProxyType")]
        public string JobAccessProxyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobAccessProxyType", this.JobAccessProxyType);
        }
    }
}

