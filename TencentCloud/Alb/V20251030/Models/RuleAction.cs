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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleAction : AbstractModel
    {
        
        /// <summary>
        /// Forward action execution sequence. Must be unique and in ascending order. Value range: 1-50000.
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// Forwarding action type. Valid values:
        /// TargetGroup: Forward to a target group.
        /// Redirect: Redirection.
        /// FixedResponse: returns fixed content.
        /// Rewrite: Rewrite.
        /// InsertHeader: Write to HTTP Header.
        /// RemoveHeader: Delete HTTP Header.
        /// The forward action must include one of TargetGroup, Redirect, or FixedResponse, and the execution order must be placed last.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Fixed response content configuration.
        /// </summary>
        [JsonProperty("FixedResponseConfig")]
        public FixedResponseInfo FixedResponseConfig{ get; set; }

        /// <summary>
        /// Insert HTTP Header configuration.
        /// </summary>
        [JsonProperty("InsertHeaderConfig")]
        public InsertHTTPHeaderInfo InsertHeaderConfig{ get; set; }

        /// <summary>
        /// Redirection configuration. Except for HttpCode, other configuration cannot all use default values.
        /// </summary>
        [JsonProperty("RedirectConfig")]
        public HTTPRedirectInfo RedirectConfig{ get; set; }

        /// <summary>
        /// Delete HTTP Header configuration.
        /// </summary>
        [JsonProperty("RemoveHeaderConfig")]
        public RemoveHTTPHeaderInfo RemoveHeaderConfig{ get; set; }

        /// <summary>
        /// Rewrite the configuration.
        /// </summary>
        [JsonProperty("RewriteConfig")]
        public HTTPRewriteInfo RewriteConfig{ get; set; }

        /// <summary>
        /// Forwarding target group configuration.
        /// </summary>
        [JsonProperty("TargetGroupConfig")]
        public TargetGroupConfig TargetGroupConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "FixedResponseConfig.", this.FixedResponseConfig);
            this.SetParamObj(map, prefix + "InsertHeaderConfig.", this.InsertHeaderConfig);
            this.SetParamObj(map, prefix + "RedirectConfig.", this.RedirectConfig);
            this.SetParamObj(map, prefix + "RemoveHeaderConfig.", this.RemoveHeaderConfig);
            this.SetParamObj(map, prefix + "RewriteConfig.", this.RewriteConfig);
            this.SetParamObj(map, prefix + "TargetGroupConfig.", this.TargetGroupConfig);
        }
    }
}

