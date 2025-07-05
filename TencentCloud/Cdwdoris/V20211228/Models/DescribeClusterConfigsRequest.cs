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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterConfigsRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 0 indicates public cloud query, and 1 Qinge query. Qinge query shows all that needs to be displayed.
        /// </summary>
        [JsonProperty("ConfigType")]
        public long? ConfigType{ get; set; }

        /// <summary>
        /// Search for files with fuzzy keywords
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 0 indicates cluster dimension and 1 node dimension
        /// </summary>
        [JsonProperty("ClusterConfigType")]
        public long? ClusterConfigType{ get; set; }

        /// <summary>
        /// eth0's IP address
        /// </summary>
        [JsonProperty("IPAddress")]
        public string IPAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "ClusterConfigType", this.ClusterConfigType);
            this.SetParamSimple(map, prefix + "IPAddress", this.IPAddress);
        }
    }
}

