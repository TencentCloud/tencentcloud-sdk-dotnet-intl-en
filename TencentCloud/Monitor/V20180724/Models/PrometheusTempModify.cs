/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class PrometheusTempModify : AbstractModel
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// This parameter is valid if `Level` is `cluster`.
        /// List of ServiceMonitor rules in the template.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceMonitors")]
        public PrometheusConfigItem[] ServiceMonitors{ get; set; }

        /// <summary>
        /// This parameter is valid if `Level` is `cluster`.
        /// List of PodMonitor rules in the template.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PodMonitors")]
        public PrometheusConfigItem[] PodMonitors{ get; set; }

        /// <summary>
        /// This parameter is valid if `Level` is `cluster`.
        /// List of RawJob rules in the template.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RawJobs")]
        public PrometheusConfigItem[] RawJobs{ get; set; }

        /// <summary>
        /// This parameter is valid if `Level` is `instance`.
        /// List of recording rules in the template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecordRules")]
        public PrometheusConfigItem[] RecordRules{ get; set; }

        /// <summary>
        /// Modification content, which is valid only if template type is `Alert`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlertDetailRules")]
        public PrometheusAlertPolicyItem[] AlertDetailRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamArrayObj(map, prefix + "ServiceMonitors.", this.ServiceMonitors);
            this.SetParamArrayObj(map, prefix + "PodMonitors.", this.PodMonitors);
            this.SetParamArrayObj(map, prefix + "RawJobs.", this.RawJobs);
            this.SetParamArrayObj(map, prefix + "RecordRules.", this.RecordRules);
            this.SetParamArrayObj(map, prefix + "AlertDetailRules.", this.AlertDetailRules);
        }
    }
}

