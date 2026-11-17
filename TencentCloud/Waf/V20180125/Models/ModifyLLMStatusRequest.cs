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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLLMStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Switch status. true: enabled; false: disabled.</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>Domain or service ID to operate on</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Switch type, used to specify the protection module switch to operate on. Valid values: <br>1: Master protection switch, controls the global enablement/disablement of the large model protection feature. <br>2: Compute consumption protection rule switch, controls the enablement/disablement of the compute consumption limiting feature. <br>3: Custom protection rule switch, controls the enablement/disablement of the custom content security rule feature. <br>4: ToolCall protection switch, controls the enablement/disablement of the tool call security detection feature. <br>5: Prompt attack protection switch, controls the enablement/disablement of the prompt injection/jailbreak attack detection feature. <br>6: Content compliance detection switch, controls the enablement/disablement of the input/output content compliance detection feature. <br>7: Sensitive data detection switch, controls the enablement/disablement of the sensitive information leakage detection (DLP) feature. <br>8: Skill security detection switch, controls the enablement/disablement of the Skill/Plugin call security detection feature. <br>9: Intent behavior detection switch, controls the enablement/disablement of the user intent recognition and behavior detection feature. <br>10: Malicious URL detection switch, controls the enablement/disablement of the malicious link detection feature in responses.</p>
        /// </summary>
        [JsonProperty("SwitchType")]
        public ulong? SwitchType{ get; set; }

        /// <summary>
        /// <p>WAF instance ID, indicating the WAF instance to which the current operation belongs. It can be obtained through the DescribeInstances API.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SwitchType", this.SwitchType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

