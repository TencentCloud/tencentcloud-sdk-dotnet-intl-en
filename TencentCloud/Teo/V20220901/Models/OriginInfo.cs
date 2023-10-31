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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginInfo : AbstractModel
    {
        
        /// <summary>
        /// The origin type. Values:
        /// <li>`IP_DOMAIN`: IPv4/IPv6 address or domain name</li>
        /// <li>`COS`: COS bucket address</li>
        /// <li>`ORIGIN_GROUP`: Origin group</li>
        /// <li>`AWS_S3`: AWS S3 bucket address</li>
        /// <li>`LB`: Tencent Cloud CLB instance</li>
        /// <li>`SPACE`: EdgeOne Shield Space</li>  
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// The origin address. Enter the origin group ID if `OriginType=ORIGIN_GROUP`.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// ID of the backup origin group (valid when `OriginType=ORIGIN_GROUP`). If it’s not specified, it indicates not to use backup origins.
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// Whether to allow access to the private object storage origin (valid when `OriginType=COS/AWS_S3`). Values:
        /// u200c<li>`on`: Enable private authentication.</li>
        /// <li>`off`: (Default) Disable private authentication.</li>
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// The private authentication parameters. This field is valid when `PrivateAccess=on`.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "BackupOrigin", this.BackupOrigin);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
        }
    }
}

