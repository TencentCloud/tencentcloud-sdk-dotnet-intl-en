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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateForwardingRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Global acceleration instance ID.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Listener ID.</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>Policy ID.</p>
        /// </summary>
        [JsonProperty("ForwardingPolicyId")]
        public string ForwardingPolicyId{ get; set; }

        /// <summary>
        /// <p>Layer 7 forwarding rule conditional information.</p><p>Array length cannot exceed 1.</p>
        /// </summary>
        [JsonProperty("RuleConditions")]
        public RuleCondition[] RuleConditions{ get; set; }

        /// <summary>
        /// <p>Layer 7 forwarding rule behavior information.</p><p>The length of the array cannot exceed 1.</p>
        /// </summary>
        [JsonProperty("RuleActions")]
        public RuleAction[] RuleActions{ get; set; }

        /// <summary>
        /// <p>Origin-pull Header information.</p><p>The maximum length of the array cannot exceed 5. This field is required when RuleActions.RuleActionType is ForwardGroup.</p>
        /// </summary>
        [JsonProperty("OriginHeaders")]
        public OriginHeader[] OriginHeaders{ get; set; }

        /// <summary>
        /// <p>Whether origin-pull sni is enabled.</p><p>Default value: False</p><p>This field is required when RuleActions.RuleActionType is ForwardGroup.</p>
        /// </summary>
        [JsonProperty("EnableOriginSni")]
        public bool? EnableOriginSni{ get; set; }

        /// <summary>
        /// <p>Origin sni.</p><p>Input parameter limit: length cannot exceed 80.</p><p>This field is required when EnableOriginSni is True. This field is required when RuleActions.RuleActionType is ForwardGroup.</p>
        /// </summary>
        [JsonProperty("OriginSni")]
        public string OriginSni{ get; set; }

        /// <summary>
        /// <p>Origin-pull host.</p><p>Input parameter limit: length not exceeding 80.</p><p>This field is required when RuleActions.RuleActionType is ForwardGroup.</p>
        /// </summary>
        [JsonProperty("OriginHost")]
        public string OriginHost{ get; set; }

        /// <summary>
        /// <p>Origin response headers</p><p>Array length not exceeding 5. An empty array can be passed, representing configuration clearing.</p>
        /// </summary>
        [JsonProperty("ResponseHeaders")]
        public ResponseHeaders[] ResponseHeaders{ get; set; }

        /// <summary>
        /// <p>Delete origin server response headers</p><p>Array length not exceeding 5. An empty array can be passed, representing configuration clearing.</p>
        /// </summary>
        [JsonProperty("HideResponseHeaders")]
        public HideResponseHeaders[] HideResponseHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ForwardingPolicyId", this.ForwardingPolicyId);
            this.SetParamArrayObj(map, prefix + "RuleConditions.", this.RuleConditions);
            this.SetParamArrayObj(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamArrayObj(map, prefix + "OriginHeaders.", this.OriginHeaders);
            this.SetParamSimple(map, prefix + "EnableOriginSni", this.EnableOriginSni);
            this.SetParamSimple(map, prefix + "OriginSni", this.OriginSni);
            this.SetParamSimple(map, prefix + "OriginHost", this.OriginHost);
            this.SetParamArrayObj(map, prefix + "ResponseHeaders.", this.ResponseHeaders);
            this.SetParamArrayObj(map, prefix + "HideResponseHeaders.", this.HideResponseHeaders);
        }
    }
}

