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

    public class EnableOriginACLRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Origin protection mode for Layer 7 accelerated domains. Default value: specific.<li>all: <strong>Automatic protection mode</strong>. All Layer 7 accelerated domains in the site are automatically added to the origin protection list, including Layer 7 accelerated domains added later.</li><li>specific: <strong>Manual protection mode</strong>. You need to manually specify the Layer 7 accelerated domains to be added to origin protection (specified by the L7Hosts parameter). Resources not specified are not added to the origin protection list. You can adjust protected resources later through the ModifyOriginACL API.</li>Note: When the value is all, leave L7Hosts empty. When the number of Layer 7 accelerated domains in the site exceeds 200, enable protection in specific mode first, enable the remaining resources through the ModifyOriginACL API, and then switch to all through the ModifyOriginACL API.</p>
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// <p>List of Layer 7 accelerated domains for which origin protection is to be enabled. This parameter takes effect only when L7EnableMode is specific. A maximum of 200 Layer 7 accelerated domains can be enabled at a time. If you want to enable more than 200 domains, use the ModifyOriginACL API for sharded configuration.</p>
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// <p>Origin protection mode for layer-4 proxy instances. Default value: specific.<li>all: <strong>Automatic protection mode</strong>. All layer-4 proxy instances in the site are automatically added to the origin protection list, including layer-4 proxy instance resources added later.</li><li>specific: <strong>Manual protection mode</strong>. You need to manually specify the layer-4 proxy instances to be added to origin protection (specified by the L4ProxyIds parameter). Resources not specified are not added to the origin protection list. You can adjust protected resources later through the ModifyOriginACL API.</li>Note: When the value is all, leave L4ProxyIds empty. When the number of layer-4 proxy instances in the site exceeds 100, enable protection in specific mode first, enable the remaining resources through the ModifyOriginACL API, and then switch to all through the ModifyOriginACL API.</p>
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// <p>List of layer-4 proxy instances for which origin protection is to be enabled. This parameter takes effect only when L4EnableMode is specific. A maximum of 100 layer-4 proxy instances can be enabled at a time. If you want to enable more than 100 layer-4 proxy instances, use the ModifyOriginACL API for sharded configuration.</p>
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// <p>Origin ACL control domain for origin protection. If not specified, the standard global control domain is used by default. Available control domains can be obtained through the DescribeAvailableOriginACLFamily API.<br>Valid values:</p><li>gaz: standard global AZ control domain;</li><li>mlc: standard Chinese mainland AZ control domain;</li><li>emc: standard global (excluding Chinese mainland) AZ control domain;</li><li>plat-gaz: simplified global AZ control domain;</li><li>plat-mlc: simplified Chinese mainland AZ control domain;</li><li>plat-emc: simplified global (excluding Chinese mainland) AZ control domain;</li>
        /// </summary>
        [JsonProperty("OriginACLFamily")]
        public string OriginACLFamily{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "L7EnableMode", this.L7EnableMode);
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

