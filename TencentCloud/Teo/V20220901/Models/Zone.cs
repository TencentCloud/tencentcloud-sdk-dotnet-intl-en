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
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Identical site identifier. It can contain digits, letters, ".", "-", and "_", up to 200 characters.
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }

        /// <summary>
        /// Site acceleration region. Valid values:
        /// <li> global: global availability zone;</li>
        /// <li>mainland: Chinese mainland availability zone;</li>
        /// <li>overseas: global availability zone (excluding the Chinese mainland).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Site access type. Valid values:
        /// <li>full: NS access type;</li>
        /// <li>partial: CNAME access type;</li>
        /// <li>noDomainAccess: domainless access type.</li>
        /// <li>dnsPodAccess: DNSPod managed type. This type requires your domain name to be hosted on Tencent Cloud DNSPod;</li>
        /// <li> pages: Pages type;</li>
        /// <li> ai: Edge reasoning access type.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Tag associated with the site.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// List of billable resources.
        /// </summary>
        [JsonProperty("Resources")]
        public Resource[] Resources{ get; set; }

        /// <summary>
        /// Site detail of the NS type. This value is returned only when Type is full.
        /// </summary>
        [JsonProperty("NSDetail")]
        public NSDetail NSDetail{ get; set; }

        /// <summary>
        /// Site detail of CNAME type. This value is returned only when Type is partial.
        /// </summary>
        [JsonProperty("CNAMEDetail")]
        public CNAMEDetail CNAMEDetail{ get; set; }

        /// <summary>
        /// DNSPod managed type site detail. This return value is only available when Type = dnsPodAccess.
        /// </summary>
        [JsonProperty("DNSPodDetail")]
        public DNSPodDetail DNSPodDetail{ get; set; }

        /// <summary>
        /// Site creation time.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Site modification time.
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// Site status. Valid values:
        /// <li> active: NS switched; </li>
        /// <li>pending: NS not switched.</li>
        /// <li> moved: The NS has been moved away;</li>
        /// <li>`deactivated`: The name server is blocked.</li>
        /// <li> initializing: Package to be bound. </li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// CNAME access status. Valid values:
        /// <li> finished: site verified;</li>
        /// <li> pending: verifying site.</li>
        /// </summary>
        [JsonProperty("CnameStatus")]
        public string CnameStatus{ get; set; }

        /// <summary>
        /// Display status. Valid values:
        /// <li> active: enabled;</li>
        /// <li> inactive: Not effective;</li>
        /// <li> paused: disabled.</li>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public string ActiveStatus{ get; set; }

        /// <summary>
        /// Lock status. Valid values: <li> enable: normal. Modifications are allowed;</li><li> disable: locked. Modifications are not allowed;</li><li> plan_migrate: package migrating. Modifications are not allowed.</li>
        /// </summary>
        [JsonProperty("LockStatus")]
        public string LockStatus{ get; set; }

        /// <summary>
        /// Whether to close the site.
        /// </summary>
        [JsonProperty("Paused")]
        public bool? Paused{ get; set; }

        /// <summary>
        /// Whether it is a fake site (this field is a reserved field for history and is no longer maintained. According to the website type, see the corresponding field). Valid values:
        /// <li>0: non-fake site</li>
        /// <li> 1: Fake site.</li>
        /// </summary>
        [JsonProperty("IsFake")]
        public long? IsFake{ get; set; }

        /// <summary>
        /// Whether CNAME acceleration is enabled (this is a historic reserved field and no longer maintained. For the corresponding field, see the website type). Valid values:
        /// <li> enabled: Enable;</li>
        /// <li> disabled: Disable.</li>
        /// </summary>
        [JsonProperty("CnameSpeedUp")]
        public string CnameSpeedUp{ get; set; }

        /// <summary>
        /// Ownership verification information. (This field is a historic reserved field and is no longer maintained. For the corresponding field, see the website type.)
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// List of NS currently used by the site. (This field is a reserved field for history and is no longer maintained. According to the website type, see the corresponding field for reference.)
        /// </summary>
        [JsonProperty("OriginalNameServers")]
        public string[] OriginalNameServers{ get; set; }

        /// <summary>
        /// List of NS assigned by Tencent Cloud. (This field is a reserved field for history and no longer maintained. For reference, see the corresponding field based on the website type.)
        /// </summary>
        [JsonProperty("NameServers")]
        public string[] NameServers{ get; set; }

        /// <summary>
        /// User-customized NS information. (This is a reserved field for history and is no longer maintained. Refer to the corresponding field based on the website type.)
        /// </summary>
        [JsonProperty("VanityNameServers")]
        public VanityNameServers VanityNameServers{ get; set; }

        /// <summary>
        /// User-customized NS IP information. (This is a reserved field for historical purposes and is no longer maintained. Refer to the corresponding field based on the website type.)
        /// </summary>
        [JsonProperty("VanityNameServersIps")]
        public VanityNameServersIps[] VanityNameServersIps{ get; set; }

        /// <summary>
        /// Version management configuration group working mode. Each configuration module of a site can enable "version management mode" or "immediate effect mode" by configuration group dimension. For details, see [Version Management](https://www.tencentcloud.com/document/product/1552/113690?from_cn_redirect=1).
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

