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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// The list of Internet boundary rules to be added cannot be empty. Each rule must meet the requirements for direction, source and target, action, scope, protocol port, and template restrictions. The entire request must also comply with rule quota and effective rule count limitations. Account-related values must come from read-only queries: for address templates, call DescribeAddressTemplateList, filter the request with TemplateType=1 or 5, and confirm that the returned Data[].Type is 1 or 5. Write Data[].Uuid (with the mb_ prefix) to the corresponding Content, and do not use Data[].TemplateId (with the ip-/dm- prefix). For protocol port templates, filter the request with TemplateType=6, and write Data[].TemplateId (with the pp- prefix) to ParamTemplateId. For asset instances, call DescribeCfwAssets, parse the returned results, and use assets[].instance_id. For asset groups, call DescribeResourceGroupNew, pass QueryType=resource, GroupId="0", ShowType=all, parse the returned results, and use GroupId. For resource tags, pass QueryType=tag, skip the "all assets" root node, and construct JSON using the first-level node GroupName as the Key and the selected second-level sub-node GroupName as the Value, without writing GroupId. For regions, call DescribeAclRegInfo: for Scope=serial, pass FwType=["SERIAL"]; for Scope=side, pass FwType=["BYPASS"]; for Scope=all, pass both items simultaneously, and use Data[].RegionCode. Do not use display names or manually concatenate values. The range for overwrite import is determined solely by the Direction of the first rule.
        /// </summary>
        [JsonProperty("Rules")]
        public CreateRuleItem[] Rules{ get; set; }

        /// <summary>
        /// <p>AI operation source</p><p>Enumeration value:</p><ul><li>console: console source value</li><li>wechat: WeChat</li></ul>
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// Add method. Omit or an empty string means ordinary addition; insert_rule means adding new at a specified position; batch_import means non-overwrite batch import; batch_import_cover means overwrite import, which deletes the existing operation rule corresponding to the first rule's Direction and then adds Rules. Deleted rules will not be restored if addition fails, with extremely high risk. The coverage area is only determined by the first rule. The caller must ensure the Directions of the Rules match. Only the above values are supported.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "From", this.From);
        }
    }
}

