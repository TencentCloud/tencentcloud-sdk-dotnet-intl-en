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

    public class ModifyOriginACLRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Origin protection mode for layer-7 accelerated domains. Default value: specific.<li>all: <strong>Automatic protection mode</strong>. All layer-7 accelerated domains in the site will be automatically added to the origin protection list, including newly added layer-7 accelerated domains;</li><li>specific: <strong>Manual protection mode</strong>. You need to manually specify the layer-7 accelerated domains to be added to origin protection (specified by the L7Hosts parameter). Resources not specified will not be added to the origin protection list. Subsequent protection resource adjustments can be made through the ModifyOriginACL API.</li>Note: When the value is all, leave L7Hosts empty; when the number of layer-7 accelerated domains under the site exceeds 200, enable protection in specific mode first, enable the remaining resources through the ModifyOriginACL API, and then switch to all through the ModifyOriginACL API.</p>
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// <p>Origin protection mode for layer-4 proxy instances. Default value: specific.<li>all: <strong>Automatic protection mode</strong>. All layer-4 proxy instances in the site will be automatically added to the origin protection list, including newly added layer-4 proxy instance resources;</li><li>specific: <strong>Manual protection mode</strong>. You need to manually specify the layer-4 proxy instances to be added to origin protection (specified by the L4ProxyIds parameter). Resources not specified will not be added to the origin protection list. Subsequent protection resource adjustments can be made through the ModifyOriginACL API.</li>Note: When the value is all, leave L4ProxyIds empty; when the number of layer-4 proxy instances under the site exceeds 100, enable protection in specific mode first, enable the remaining resources through the ModifyOriginACL API, and then switch to all through the ModifyOriginACL API.</p>
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// <p>Instances for which origin-pull from specific origin IP ranges needs to be enabled or disabled.<br>Note: This parameter is only applicable to resource adjustment in <strong>Manual protection mode</strong>; When the origin protection mode of the corresponding level is all, the resource list of this type is automatically maintained by the system. Do not include resources of this type in this parameter. For manual adjustment, switch the corresponding level to specific through L7EnableMode/L4EnableMode first.</p>
        /// </summary>
        [JsonProperty("OriginACLEntities")]
        public OriginACLEntity[] OriginACLEntities{ get; set; }

        /// <summary>
        /// <p>Origin protection origin-pull ACL control domain. If not filled in, it remains unchanged by default; Control domain information can be obtained through the DescribeAvailableOriginACLFamily API.<br>Specific values are described as follows:</p><li>gaz: Standard global AZ control domain;</li><li>mlc: Standard Chinese mainland AZ control domain;</li><li>emc: Standard global (excluding Chinese mainland) AZ control domain;</li><li>plat-gaz: Simplified global AZ control domain;</li><li>plat-mlc: Simplified Chinese mainland AZ control domain;</li><li>plat-emc: Simplified global (excluding Chinese mainland) AZ control domain;</li>
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
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArrayObj(map, prefix + "OriginACLEntities.", this.OriginACLEntities);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

