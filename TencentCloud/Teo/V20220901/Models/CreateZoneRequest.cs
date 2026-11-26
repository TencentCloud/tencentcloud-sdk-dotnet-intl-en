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

    public class CreateZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// Site access type. If this parameter is not input, the default value `partial` is used. Valid values of this parameter are as follows:
        /// <li>partial: CNAME access;</li>
        /// <li>full: NS access;</li>
        /// <li>noDomainAccess: access with no domain name.</li>
        /// <li>dnsPodAccess: DNSPod managed access. To use this access mode, your domain name should have been hosted on DNSPod;</li>
        /// <li>ai: Edge reasoning integration.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Site name. For CNAME/NS access, pass in the second-level domain (example.com) as the site name. For domainless access, leave this value empty.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Acceleration region of the layer-7 domain name when Type is partial/full. The following are the values for this parameter. If left empty, the default value is overseas. When Type is noDomainAccess, retain this value as empty:
        /// <li> global: global availability zone;</li>
        /// <li>mainland: Chinese mainland availability zone;</li>
        /// <li>overseas: global availability zone (excluding the Chinese mainland).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// ID of the target bundle to bind. If your account already has a bundle, you can fill in this parameter to bind the site to it directly. If you currently have no bindable bundle, you can purchase one through [CreatePlan](https://www.tencentcloud.com/document/product/1552/105771?from_cn_redirect=1).
        /// Note: If this parameter is not specified, a site in the "init" state will be created. The site is inactive and will not be displayed in the console. You can access [BindZoneToPlan](https://www.tencentcloud.com/document/product/1552/83042?from_cn_redirect=1) to bind a package and activate the site. After activation, the site can provide services properly.
        /// 
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Identical site identifier. Only numbers, English letters, ".", "-", and "_" are allowed, up to 200 characters. For details, see [Identical Site Identifier](https://www.tencentcloud.com/document/product/1552/70202?from_cn_redirect=1). If this usage scenario does not apply, just leave this field empty.
        /// </summary>
        [JsonProperty("AliasZoneName")]
        public string AliasZoneName{ get; set; }

        /// <summary>
        /// Tag. This parameter is used for authority control and cost allocation of the site. You need to go to the [tag console](https://console.cloud.tencent.com/tag/taglist) to create the corresponding tag before you can input the corresponding tag key and tag value here.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether repeated access is allowed.
        /// <li> true: Allow repeated access;</li>
        /// <li> false: Duplicate integration is not allowed.</li>If this field is not specified, the default value 'false' will be used.
        /// </summary>
        [JsonProperty("AllowDuplicates")]
        [System.Obsolete]
        public bool? AllowDuplicates{ get; set; }

        /// <summary>
        /// Whether to skip scanning existing DNS records of the site. Default value: false.
        /// </summary>
        [JsonProperty("JumpStart")]
        [System.Obsolete]
        public bool? JumpStart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "AliasZoneName", this.AliasZoneName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AllowDuplicates", this.AllowDuplicates);
            this.SetParamSimple(map, prefix + "JumpStart", this.JumpStart);
        }
    }
}

