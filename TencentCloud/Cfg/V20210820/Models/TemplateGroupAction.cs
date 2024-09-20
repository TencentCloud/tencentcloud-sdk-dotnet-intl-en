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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateGroupAction : AbstractModel
    {
        
        /// <summary>
        /// Template library group action ID
        /// </summary>
        [JsonProperty("TemplateGroupActionId")]
        public long? TemplateGroupActionId{ get; set; }

        /// <summary>
        /// Action ID
        /// </summary>
        [JsonProperty("ActionId")]
        public long? ActionId{ get; set; }

        /// <summary>
        /// Order of actions in the group
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// General configurations of actions in the group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GeneralConfiguration")]
        public string GeneralConfiguration{ get; set; }

        /// <summary>
        /// Custom configurations of actions in the group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public string CustomConfiguration{ get; set; }

        /// <summary>
        /// Action group creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Action group update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Action name
        /// </summary>
        [JsonProperty("ActionTitle")]
        public string ActionTitle{ get; set; }

        /// <summary>
        /// Random ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RandomId")]
        public long? RandomId{ get; set; }

        /// <summary>
        /// Recovery action ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecoverId")]
        public long? RecoverId{ get; set; }

        /// <summary>
        /// Executed action ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecuteId")]
        public long? ExecuteId{ get; set; }

        /// <summary>
        /// Called API type. 0: tat; 1: cloud API.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionApiType")]
        public long? ActionApiType{ get; set; }

        /// <summary>
        /// 1: fault; 2: recovery.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionAttribute")]
        public long? ActionAttribute{ get; set; }

        /// <summary>
        /// Action type: platform and custom
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Action risk level. 1: low-risk; 2: medium-risk; 3: high-risk.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionRisk")]
        public string ActionRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateGroupActionId", this.TemplateGroupActionId);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "GeneralConfiguration", this.GeneralConfiguration);
            this.SetParamSimple(map, prefix + "CustomConfiguration", this.CustomConfiguration);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ActionTitle", this.ActionTitle);
            this.SetParamSimple(map, prefix + "RandomId", this.RandomId);
            this.SetParamSimple(map, prefix + "RecoverId", this.RecoverId);
            this.SetParamSimple(map, prefix + "ExecuteId", this.ExecuteId);
            this.SetParamSimple(map, prefix + "ActionApiType", this.ActionApiType);
            this.SetParamSimple(map, prefix + "ActionAttribute", this.ActionAttribute);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionRisk", this.ActionRisk);
        }
    }
}

