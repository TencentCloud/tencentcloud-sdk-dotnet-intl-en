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

    public class UpdatePrometheusAlertGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// prometheus instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Alert group ID, such as alert-xxxx.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Alert group name. not allowed to have the same name as other alert groups.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Alert group status.
        /// 2 - enable.
        /// 3 - disabled.
        /// Specifies the Alert rule status under the `Rules` field to be overwritten when not empty.
        /// </summary>
        [JsonProperty("GroupState")]
        public long? GroupState{ get; set; }

        /// <summary>
        /// Alert notification template ID list of tencent cloud observability platform, such as Consumer-xxxx or notice-xxxx.
        /// </summary>
        [JsonProperty("AMPReceivers")]
        public string[] AMPReceivers{ get; set; }

        /// <summary>
        /// Specifies the custom Alert notification template.
        /// </summary>
        [JsonProperty("CustomReceiver")]
        public PrometheusAlertCustomReceiver CustomReceiver{ get; set; }

        /// <summary>
        /// Alert notification cycle (convergence time). defaults to 1h if left empty.
        /// </summary>
        [JsonProperty("RepeatInterval")]
        public string RepeatInterval{ get; set; }

        /// <summary>
        /// Specifies the Alert rule list to be created.
        /// </summary>
        [JsonProperty("Rules")]
        public PrometheusAlertGroupRuleSet[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupState", this.GroupState);
            this.SetParamArraySimple(map, prefix + "AMPReceivers.", this.AMPReceivers);
            this.SetParamObj(map, prefix + "CustomReceiver.", this.CustomReceiver);
            this.SetParamSimple(map, prefix + "RepeatInterval", this.RepeatInterval);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

