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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncDBEndpointInfos : AbstractModel
    {
        
        /// <summary>
        /// Database region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance network access type. For example: extranet (public network), ipv6 (public network ipv6), cvm (self-built CVM), dcg (DC), vpncloud (instance accessed via VPN), cdb (cloud database), ccn (CCN), intranet (self-developed cloud migration), and vpc (VPC). Note that the specific valid values depend on the current linkage.
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// Instance database type. For example: mysql, redis, mongodb, postgresql, mariadb, and percona.
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// Database information. Note: If the database type is tdsqlmysql, the order of the Endpoint array should follow the following rule: proxy nodes are placed before set nodes. If SrcConnectType selects proxy access, only the proxy node needs to be filled. If set access is selected, the first set node in the array should be the shard with a shardkey range starting from 0.
        /// </summary>
        [JsonProperty("Info")]
        public Endpoint[] Info{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamArrayObj(map, prefix + "Info.", this.Info);
        }
    }
}

