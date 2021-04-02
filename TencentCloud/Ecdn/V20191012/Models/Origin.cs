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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// Primary origin server list. IP and the domain name of the origin server cannot be entered at the same time. Configure origin server port in the format of ["origin1:port1", "origin2:port2"]. Configure origin-pull weight in the format of ["origin1::weight1", "origin2::weight2"]. Configure both port and weight in the format of ["origin1:port1:weight1", "origin2:port2:weight2"]. Valid range of weight value: 0 - 100.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Primary origin server type. Valid values: domain (domain name origin server), ip (IP origin server).
        /// This is required when setting `Origins`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Host header value during origin-pull.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// Origin-pull protocol type. Valid values: http (forced HTTP origin-pull), follow (protocol follow), https (HTTPS origin-pull).
        /// If this parameter is left empty, HTTP origin-pull will be used by default.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// Secondary origin server list.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// Secondary origin server type, which is the same as `OriginType`.
        /// This is required when setting `BackupOrigins`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupOriginType")]
        public string BackupOriginType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "BackupOriginType", this.BackupOriginType);
        }
    }
}

