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

    public class Zone : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Identical site identifier. specifies a composite of numbers, english letters, ".", "-", and "_" with a character limit of 200.
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }

        /// <summary>
        /// Site acceleration region. valid values:.
        /// <Li>Global: global availability zone.</li>.
        /// <Li>Mainland: chinese mainland availability zone.</li>.
        /// <li>overseas: global availability zone (excluding the chinese mainland).</li>.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Site access type. valid values:.
        /// <li>full: NS access type;</li>.
        /// <li>partial: CNAME access type;</li>.
        /// <li>noDomainAccess: domainless access type.</li>.
        /// <li>dnsPodAccess: DNSPod managed type. this type requires your domain name to be hosted on tencent cloud DNSPod.</li>.
        /// <li> pages: pages data type;</li>.
        /// <li>ai: edge reasoning access type.</li>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Specifies the Tag associated with the site.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The list of billable resources.
        /// </summary>
        [JsonProperty("Resources")]
        public Resource[] Resources{ get; set; }

        /// <summary>
        /// NS site detail. returned only when Type = full.
        /// </summary>
        [JsonProperty("NSDetail")]
        public NSDetail NSDetail{ get; set; }

        /// <summary>
        /// CNAME site detail. returned only when Type = partial.
        /// </summary>
        [JsonProperty("CNAMEDetail")]
        public CNAMEDetail CNAMEDetail{ get; set; }

        /// <summary>
        /// DNSPod managed Type site detail. returned only when Type = dnsPodAccess.
        /// </summary>
        [JsonProperty("DNSPodDetail")]
        public DNSPodDetail DNSPodDetail{ get; set; }

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
        /// The site status. Values:
        /// u200c<li>`active`: The name server is switched to EdgeOne.</li>
        /// u200c<li>`pending`: The name server is not switched.</li>
        /// u200c<li>`moved`: The name server is changed to other service providers.</li>
        /// u200c<li>`deactivated`: The site is blocked.</li>
        /// <li>`initializing`: The site is not bound with any plan. </li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// CNAME record access status. Values:
        /// <li>`finished`: The site is verified.</li>
        /// <li>`pending`: The site is being verified.</li>
        /// </summary>
        [JsonProperty("CnameStatus")]
        public string CnameStatus{ get; set; }

        /// <summary>
        /// Status of the proxy. Values:
        /// <li>`active`: Enabled</li>
        /// <li>`inactive`: Not activated</li>
        /// <li>`paused`: Disabled</li>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public string ActiveStatus{ get; set; }

        /// <summary>
        /// Lock status. Values: <li>`enable`: Normal. Modification is allowed.</li><li>`disable`: Locked. Modification is not allowed.</li><li>`plan_migrate`: Adjusting the plan. Modification is not allowed.</li> 
        /// </summary>
        [JsonProperty("LockStatus")]
        public string LockStatus{ get; set; }

        /// <summary>
        /// Whether the site is disabled.
        /// </summary>
        [JsonProperty("Paused")]
        public bool? Paused{ get; set; }

        /// <summary>
        /// Specifies whether it is a fake site (this field is a historic reserved field and is no longer maintained, refer to the website type for the corresponding field). valid values:.
        /// <Li>0: non-fake site.</li>.
        /// <Li>1: fake site.</li>.
        /// </summary>
        [JsonProperty("IsFake")]
        public long? IsFake{ get; set; }

        /// <summary>
        /// Whether to enable CNAME acceleration (this field is a historic reserved field and is no longer maintained. refer to the website type for the corresponding field). valid values:.
        /// <Li>Enabled: specifies whether the feature is enabled.</li>.
        /// <li>disabled: specifies that the feature is turned off.</li>.
        /// </summary>
        [JsonProperty("CnameSpeedUp")]
        public string CnameSpeedUp{ get; set; }

        /// <summary>
        /// Ownership verification information. (this field is a historic reserved field and is no longer maintained. refer to the website type for the corresponding field.).
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// Lists the currently used NS of the site. (this field is a historic reserved field and is no longer maintained. refer to the corresponding field based on the website type.).
        /// </summary>
        [JsonProperty("OriginalNameServers")]
        public string[] OriginalNameServers{ get; set; }

        /// <summary>
        /// Lists of NS assigned by tencent cloud. (this field is a historic reserved field and no longer maintained. refer to the website type for the corresponding field.).
        /// </summary>
        [JsonProperty("NameServers")]
        public string[] NameServers{ get; set; }

        /// <summary>
        /// Specifies user-customized NS information. (this field is a historic reserved field and is no longer maintained. refer to the corresponding field according to the website type.).
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("VanityNameServers")]
        public VanityNameServers VanityNameServers{ get; set; }

        /// <summary>
        /// User-Customized NS IP information. (this field is a historic reserved field and is no longer maintained. refer to the corresponding field according to the website type.).
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("VanityNameServersIps")]
        public VanityNameServersIps[] VanityNameServersIps{ get; set; }

        /// <summary>
        /// Version management configuration group working mode. site configuration modules can enable "version management mode" or "immediate effect mode" by configuration group dimension. for details, see [version management](https://www.tencentcloud.comom/document/product/1552/113690?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("WorkModeInfos")]
        public ConfigGroupWorkModeInfo[] WorkModeInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "NSDetail.", this.NSDetail);
            this.SetParamObj(map, prefix + "CNAMEDetail.", this.CNAMEDetail);
            this.SetParamObj(map, prefix + "DNSPodDetail.", this.DNSPodDetail);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CnameStatus", this.CnameStatus);
            this.SetParamSimple(map, prefix + "ActiveStatus", this.ActiveStatus);
            this.SetParamSimple(map, prefix + "LockStatus", this.LockStatus);
            this.SetParamSimple(map, prefix + "Paused", this.Paused);
            this.SetParamSimple(map, prefix + "IsFake", this.IsFake);
            this.SetParamSimple(map, prefix + "CnameSpeedUp", this.CnameSpeedUp);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamArraySimple(map, prefix + "OriginalNameServers.", this.OriginalNameServers);
            this.SetParamArraySimple(map, prefix + "NameServers.", this.NameServers);
            this.SetParamObj(map, prefix + "VanityNameServers.", this.VanityNameServers);
            this.SetParamArrayObj(map, prefix + "VanityNameServersIps.", this.VanityNameServersIps);
            this.SetParamArrayObj(map, prefix + "WorkModeInfos.", this.WorkModeInfos);
        }
    }
}

