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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusAlertGroupRuleSet : AbstractModel
    {
        
        /// <summary>
        /// Alert rule name. same name is not allowed in the same Alert group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Prometheus alert label list.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public PrometheusRuleKV[] Labels{ get; set; }

        /// <summary>
        /// Prometheus alert annotation list.
        /// 
        /// Alarm object and Alarm message are special fields of Prometheus Rule Annotations. they need to pass through Annotations for transmission. the corresponding keys are summary and description respectively.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Annotations")]
        public PrometheusRuleKV[] Annotations{ get; set; }

        /// <summary>
        /// Alert will be triggered after 'Expr' satisfied for 'Duration'.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// Alert expression. see <a href="https://www.tencentcloud.comom/document/product/1416/56008?from_cn_redirect=1">alert rule description</a>.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Expr")]
        public string Expr{ get; set; }

        /// <summary>
        /// Alert rule status.
        /// 2 - enable.
        /// 3 - disabled.
        /// Enabled by default if left empty.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Expr", this.Expr);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

