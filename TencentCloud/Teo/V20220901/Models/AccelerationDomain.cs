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

    public class AccelerationDomain : AbstractModel
    {
        
        /// <summary>
        /// Details of the origin.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginDetail")]
        public OriginDetail OriginDetail{ get; set; }

        /// <summary>
        /// Creation time of the accelerated domain name.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Accelerated domain name
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Modification time of the accelerated domain name.
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Status of the accelerated domain name. Values:
        /// <li>`online`: Activated</li>
        /// <li>`process`: Being deployed</li>
        /// <li>`offline`: Disabled</li>
        /// <li>`forbidden`: Blocked</li>
        /// <li>`init`: Pending activation</li>
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string DomainStatus{ get; set; }

        /// <summary>
        /// The CNAME address.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IdentificationStatus")]
        public string IdentificationStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "OriginDetail.", this.OriginDetail);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "IdentificationStatus", this.IdentificationStatus);
        }
    }
}

