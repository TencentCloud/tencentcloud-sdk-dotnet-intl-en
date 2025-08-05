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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// Origin server list.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Backup origin list.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// Origin server protocol configuration. valid values:.
        /// <Li>Http: forced http back to source;</li>.
        /// <Li>`Follow`: follow protocol.</li>.
        /// <Li>Https: enforce https origin-pull.</li>.
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// When the origin is tencent cloud COS, whether it is a private access bucket. valid values:.
        /// <li>`on`: private network access;</li>.
        /// <li>`off`: public access.</li>.
        /// </summary>
        [JsonProperty("CosPrivateAccess")]
        public string CosPrivateAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamSimple(map, prefix + "CosPrivateAccess", this.CosPrivateAccess);
        }
    }
}

