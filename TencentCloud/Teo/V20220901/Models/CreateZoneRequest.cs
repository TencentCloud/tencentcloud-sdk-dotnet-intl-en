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

    public class CreateZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// The access mode. Values:
        /// <li>`full`: Access through a name server.</li>
        /// <li>`partial`: Access through a CNAME record. Note that you should verify your site with the IdentifyZone API before starting site access.</li>If it is left empty, the default value `full` is used.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Whether to skip scanning the existing DNS records of the site. Default value: false.
        /// </summary>
        [JsonProperty("JumpStart")]
        public bool? JumpStart{ get; set; }

        /// <summary>
        /// The resource tag.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether to allow duplicate sites. Values:
        /// <li>`true`: Duplicate sites are allowed.</li>
        /// <li>`false`: Duplicate sites are not allowed.</li>If it is left empty, the default value `false` is used.
        /// </summary>
        [JsonProperty("AllowDuplicates")]
        public bool? AllowDuplicates{ get; set; }

        /// <summary>
        /// The site alias. It can be up to 20 characters consisting of digits, letters, hyphens (-) and underscores (_).
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "JumpStart", this.JumpStart);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AllowDuplicates", this.AllowDuplicates);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
        }
    }
}

