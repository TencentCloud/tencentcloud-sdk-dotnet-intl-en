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

    public class Zone : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// List of name servers used by the site
        /// </summary>
        [JsonProperty("OriginalNameServers")]
        public string[] OriginalNameServers{ get; set; }

        /// <summary>
        /// The list of name servers assigned by Tencent Cloud.
        /// </summary>
        [JsonProperty("NameServers")]
        public string[] NameServers{ get; set; }

        /// <summary>
        /// The site status. Values:
        /// <li>`active`: The name server is switched.</li>
        /// <li>`pending`: The name server is not switched.</li>
        /// <li>`moved`: The name server is moved.</li>
        /// <li>`deactivated`: The site is blocked.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The site access method. Values:
        /// <li>`full`: Access through a name server.</li>
        /// <li>`partial`: Access through a CNAME record.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Whether the site is disabled.
        /// </summary>
        [JsonProperty("Paused")]
        public bool? Paused{ get; set; }

        /// <summary>
        /// Whether CNAME acceleration is enabled. Values:
        /// <li>`enabled`: Enabled</li>
        /// <li>`disabled`: Disabled</li>
        /// </summary>
        [JsonProperty("CnameSpeedUp")]
        public string CnameSpeedUp{ get; set; }

        /// <summary>
        /// CNAME record access status. Values:
        /// <li>`finished`: The site is verified.</li>
        /// <li>`pending`: The site is being verified.</li>
        /// </summary>
        [JsonProperty("CnameStatus")]
        public string CnameStatus{ get; set; }

        /// <summary>
        /// The list of resource tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The list of billable resources.
        /// </summary>
        [JsonProperty("Resources")]
        public Resource[] Resources{ get; set; }

        /// <summary>
        /// The creation time of the site.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// The modification date of the site.
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// The site access region. Values:
        /// <li>`global`: Global.</li>
        /// <li>`mainland`: Chinese mainland.</li>
        /// <li>`overseas`: Outside the Chinese mainland.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// The custom name server information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VanityNameServers")]
        public VanityNameServers VanityNameServers{ get; set; }

        /// <summary>
        /// The custom name server IP information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VanityNameServersIps")]
        public VanityNameServersIps[] VanityNameServersIps{ get; set; }

        /// <summary>
        /// Status of the proxy. Values:
        /// <li>`active`: Enabled</li>
        /// <li>`inactive`: Not activated</li>
        /// <li>`paused`: Disabled</li>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public string ActiveStatus{ get; set; }

        /// <summary>
        /// The site alias. It can be up to 20 characters consisting of digits, letters, hyphens (-) and underscores (_).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }

        /// <summary>
        /// Whether it’s a fake site. Valid values: 
        /// <li>`0`: Non-fake site;</li>
        /// <li>`1`: Fake site.</li>
        /// </summary>
        [JsonProperty("IsFake")]
        public long? IsFake{ get; set; }

        /// <summary>
        /// Lock status. Valid values: <li>`enable`: Normal. Modifying is allowed;</li><li>`disable`: Locked. Modifying is not allowed.</li>
        /// </summary>
        [JsonProperty("LockStatus")]
        public string LockStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamArraySimple(map, prefix + "OriginalNameServers.", this.OriginalNameServers);
            this.SetParamArraySimple(map, prefix + "NameServers.", this.NameServers);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Paused", this.Paused);
            this.SetParamSimple(map, prefix + "CnameSpeedUp", this.CnameSpeedUp);
            this.SetParamSimple(map, prefix + "CnameStatus", this.CnameStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamObj(map, prefix + "VanityNameServers.", this.VanityNameServers);
            this.SetParamArrayObj(map, prefix + "VanityNameServersIps.", this.VanityNameServersIps);
            this.SetParamSimple(map, prefix + "ActiveStatus", this.ActiveStatus);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
            this.SetParamSimple(map, prefix + "IsFake", this.IsFake);
            this.SetParamSimple(map, prefix + "LockStatus", this.LockStatus);
        }
    }
}

